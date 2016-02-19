using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Services;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.ServiceModel.Security;
using System.Xml;

namespace STS.RelyingPartyApp
{
    public class AuthController
    {
        private SecurityToken _authToken;
        public ClaimsPrincipal UserIdenity { get; private set; }

        public bool isAuthenticated()
        {
            return UserIdenity != null && UserIdenity.Identity.IsAuthenticated;
        }

        public SecurityToken GeToken()
        {
            return _authToken;
        }

        public void Login(string userName, string userPassword)
        {
            if (isAuthenticated())
            {
                Logout();
            }
            AuthInSts(userName, userPassword);
        }

        public void Logout()
        {
            _authToken = null;
            UserIdenity = null;
        }

        private void AuthInSts(string userName, string userPassword)
        {
            ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);
            var rst = new RequestSecurityToken(RequestTypes.Issue);
            rst.AppliesTo = new EndpointReference("https://RelyingParty/*");
            rst.KeyType = KeyTypes.Bearer;

            using (var trustChannelFactory = new WSTrustChannelFactory("WS2007HttpBinding_IWSTrust13Sync"))
            {
                trustChannelFactory.Credentials.UserName.UserName = userName;
                trustChannelFactory.Credentials.UserName.Password = userPassword;

                var channel = (WSTrustChannel) trustChannelFactory.CreateChannel();
                try
                {
                    _authToken = channel.Issue(rst);
                }
                catch (MessageSecurityException ex)
                {
                    channel.Abort();
                    throw new SecurityTokenException(ex.InnerException.Message, ex);
                }
                UserIdenity = CreateUserIdentityFromSecurityToken(_authToken);
            }
        }

        private ClaimsPrincipal CreateUserIdentityFromSecurityToken(SecurityToken token)
        {
            var genericToken = token as GenericXmlSecurityToken;
            var handlers =
                FederatedAuthentication.FederationConfiguration.IdentityConfiguration
                    .SecurityTokenHandlerCollectionManager.SecurityTokenHandlerCollections.FirstOrDefault();
            var cToken = handlers.ReadToken(new XmlTextReader(new StringReader(genericToken.TokenXml.OuterXml)));
            var identity = handlers.ValidateToken(cToken).FirstOrDefault();
            var userIdenity = new ClaimsPrincipal(identity);
            return userIdenity;
        }
    }
}