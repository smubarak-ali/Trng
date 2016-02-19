using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using Tranglo.Auth.Model;
using Tranglo.Auth.Services.Api.Implementation;
using Tranglo.Auth.Services.Api.Interface;

namespace Tranglo.Auth.Service.Api
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TokenService : ITokenService
    {

        public string Authenticate(User user)
        {
            ICredentialsValidator validator = new CredentialsValidatorImpl();
            var data = validator.IsValid(user);
            if (data.Id > 0)
            {
                var token = new TokenBuilderImpl().Build(data);
                HttpContext.Current.Response.AddHeader(token, "Token");
                return "Ok";
            }
            else
            {
                return "UnAuthorized Request";
            }
        }
    }
}
