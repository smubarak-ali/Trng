using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tranglo.Auth.Service.Api.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class UserAccessAttribute : Attribute
    {
        private string _role;
        private bool _authenticationRequired;

        public UserAccessAttribute()
        {

        }

        public UserAccessAttribute(string role, bool authRequired)
        {
            _role = role;
            _authenticationRequired = authRequired;
        }

        public string GetRole()
        {
            return _role;
        }

        public bool IsAuthenticationRequired()
        {
            return _authenticationRequired;
        }
    }
}