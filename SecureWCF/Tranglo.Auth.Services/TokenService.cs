using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.ServiceModel;
using System.Text;
using Tranglo.Auth.Model;
using Tranglo.Auth.Services.Implementation;
using Tranglo.Auth.Services.Interface;

namespace Tranglo.Auth.Services
{
    public class TokenService : ITokenService
    {
        public string Authenticate(User user)
        {
            ICredentialsValidator validator = new CredentialsValidatorImpl();
            if (validator.IsValid(user))
            {
                return new TokenBuilderImpl().Build(user);
            }
            throw new InvalidCredentialException("Invalid credentials");
        }
    }
}
