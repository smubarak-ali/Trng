﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tranglo.Auth.Services.BL
{
    public class JsonWebToken
    {
        private string ServerKey = "Tr@ngiZer()_Jwt-1120#$^^";
        private JwtHashAlgorithm serverJwtHashAlgorithm = JwtHashAlgorithm.HS512;
        private int MinuteExpire = 30;

        private static Dictionary<JwtHashAlgorithm, Func<byte[], byte[], byte[]>> HashAlgorithms;

        public JsonWebToken()
        {
            HashAlgorithms = new Dictionary<JwtHashAlgorithm, Func<byte[], byte[], byte[]>>
            {
                { JwtHashAlgorithm.RS256, (key, value) => { using (var sha = new HMACSHA256(key)) { return sha.ComputeHash(value); } } },
                { JwtHashAlgorithm.HS384, (key, value) => { using (var sha = new HMACSHA384(key)) { return sha.ComputeHash(value); } } },
                { JwtHashAlgorithm.HS512, (key, value) => { using (var sha = new HMACSHA512(key)) { return sha.ComputeHash(value); } } }
            };
        }

        public string Encode(object payload, string key, JwtHashAlgorithm algorithm)
        {
            return Encode(payload, Encoding.UTF8.GetBytes(key), algorithm);
        }

        public string Encode(object payload, JwtHashAlgorithm algorithm)
        {
            return Encode(payload, Encoding.UTF8.GetBytes(ServerKey), algorithm);
        }

        public string Encode(object payload)
        {
            return Encode(payload, Encoding.UTF8.GetBytes(ServerKey), serverJwtHashAlgorithm);
        }

        public string Encode(object payload, byte[] keyBytes, JwtHashAlgorithm algorithm)
        {
            TimeSpan t = DateTime.UtcNow.AddMinutes(MinuteExpire) - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            var segments = new List<string>();
            var header = new { alg = algorithm.ToString(), typ = "JWT", expire = secondsSinceEpoch };

            byte[] headerBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(header, Formatting.None));
            byte[] payloadBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(payload, Formatting.None));
            //byte[] payloadBytes = Encoding.UTF8.GetBytes(@"{"iss":"761326798069-r5mljlln1rd4lrbhg75efgigp36m78j5@developer.gserviceaccount.com","scope":"https://www.googleapis.com/auth/prediction","aud":"https://accounts.google.com/o/oauth2/token","exp":1328554385,"iat":1328550785}");

            segments.Add(Base64UrlEncode(headerBytes));
            segments.Add(Base64UrlEncode(payloadBytes));

            var stringToSign = string.Join(".", segments.ToArray());

            var bytesToSign = Encoding.UTF8.GetBytes(stringToSign);

            byte[] signature = HashAlgorithms[algorithm](keyBytes, bytesToSign);
            segments.Add(Base64UrlEncode(signature));

            return string.Join(".", segments.ToArray());
        }

        public string Decode(string token, string key)
        {
            return Decode(token, key, true);
        }

        public string Decode(string token)
        {
            return Decode(token, ServerKey, true);
        }

        public string Decode(string token, string key, bool verify)
        {
            var parts = token.Split('.');
            var header = parts[0];
            var payload = parts[1];
            byte[] crypto = Base64UrlDecode(parts[2]);

            var headerJson = Encoding.UTF8.GetString(Base64UrlDecode(header));
            var headerData = JObject.Parse(headerJson);
            var payloadJson = Encoding.UTF8.GetString(Base64UrlDecode(payload));
            var payloadData = JObject.Parse(payloadJson);

            if (verify)
            {
                var bytesToSign = Encoding.UTF8.GetBytes(string.Concat(header, ".", payload));
                var keyBytes = Encoding.UTF8.GetBytes(key);
                var algorithm = (string)headerData["alg"];

                var signature = HashAlgorithms[GetHashAlgorithm(algorithm)](keyBytes, bytesToSign);
                var decodedCrypto = Convert.ToBase64String(crypto);
                var decodedSignature = Convert.ToBase64String(signature);

                if (decodedCrypto != decodedSignature)
                {
                    throw new ApplicationException(string.Format("Invalid signature. Expected {0} got {1}", decodedCrypto, decodedSignature));
                }


                TimeSpan tsNow = DateTime.UtcNow - new DateTime(1970, 1, 1);
                int secondsNow = (int)tsNow.TotalSeconds;
                int secondsExpire = headerData["expire"] == null ? 0 : (int)headerData["expire"];

                if (secondsNow > secondsExpire)
                {
                    //token expires
                    throw new ApplicationException("Token Expired");
                }
            }

            return payloadData.ToString();
        }

        private JwtHashAlgorithm GetHashAlgorithm(string algorithm)
        {
            switch (algorithm)
            {
                case "RS256": return JwtHashAlgorithm.RS256;
                case "HS384": return JwtHashAlgorithm.HS384;
                case "HS512": return JwtHashAlgorithm.HS512;
                default: throw new InvalidOperationException("Algorithm not supported.");
            }
        }

        // from JWT spec
        private string Base64UrlEncode(byte[] input)
        {
            var output = Convert.ToBase64String(input);
            output = output.Split('=')[0]; // Remove any trailing '='s
            output = output.Replace('+', '-'); // 62nd char of encoding
            output = output.Replace('/', '_'); // 63rd char of encoding
            return output;
        }

        // from JWT spec
        private byte[] Base64UrlDecode(string input)
        {
            var output = input;
            output = output.Replace('-', '+'); // 62nd char of encoding
            output = output.Replace('_', '/'); // 63rd char of encoding
            switch (output.Length % 4) // Pad with trailing '='s
            {
                case 0: break; // No pad chars in this case
                case 2: output += "=="; break; // Two pad chars
                case 3: output += "="; break; // One pad char
                default: throw new System.Exception("Illegal base64url string!");
            }
            var converted = Convert.FromBase64String(output); // Standard base64 decoder
            return converted;
        }
    }

    public enum JwtHashAlgorithm
    {
        RS256,
        HS384,
        HS512
    }
}
