using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tranglo.Auth.Model;

namespace Tranglo.Auth.Service.Api
{
    
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        [WebGet]
        List<User> GetUsers();
    }
}
