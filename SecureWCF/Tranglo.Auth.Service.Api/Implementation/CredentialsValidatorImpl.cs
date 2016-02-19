using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranglo.Auth.DataAccess;
using Tranglo.Auth.Model;
using Tranglo.Auth.Services.Api.Interface;

namespace Tranglo.Auth.Services.Api.Implementation
{
    public class CredentialsValidatorImpl : ICredentialsValidator
    {
        UserRepository userRepo = new UserRepository();

        public User IsValid(User user)
        {
            var value = userRepo.ValidateUser(user.Username, user.Password);
            return value;
        }
    }
}
