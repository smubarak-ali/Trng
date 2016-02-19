using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranglo.Auth.Model;
using Tranglo.Auth.Services.Api.BL;
using Tranglo.Auth.Services.Api.Interface;

namespace Tranglo.Auth.Services.Api.Implementation
{
    public class TokenBuilderImpl : ITokenBuilder
    {

        public string Build(User user)
        {
            var jwtClass = new JsonWebToken();
            user.Password = string.Empty;

            string token = jwtClass.Encode(user);
            return token;
        }
    }
}
