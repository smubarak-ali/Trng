using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tranglo.Auth.Service.Api.CustomAttribute
{
    public class Token
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}