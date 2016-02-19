using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using Tranglo.Auth.Model;
using Tranglo.Auth.Services.Api.BL;

namespace Tranglo.Auth.Service.Api
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SampleService : ISampleService
    {
        JsonWebToken jwt = new JsonWebToken();

        //public List<User> GetUsers()
        //{
        //    string userToken = string.Empty;
        //    userToken = HttpContext.Current.Request.Headers.Get("token");
        //    jwt.Decode(userToken);
        //}
    }
}
