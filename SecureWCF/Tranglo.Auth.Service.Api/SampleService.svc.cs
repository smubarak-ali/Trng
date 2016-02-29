using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using Tranglo.Auth.Model;
using Tranglo.Auth.Service.Api.CustomAttribute;
using Tranglo.Auth.Services.Api.BL;

namespace Tranglo.Auth.Service.Api
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SampleService : ISampleService
    {
        JsonWebToken jwt = new JsonWebToken();

        [UserAccess(role: "admin", authRequired: false)]
        public List<User> GetUsers()
        {
            var list = new List<User>();
            string userToken = string.Empty;
            userToken = HttpContext.Current.Request.Headers.Get("Username");
            //jwt.Decode(userToken);
            return list;
        }
    }
}
