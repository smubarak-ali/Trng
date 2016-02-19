using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services.Description;

namespace Tranglo.Auth.Service.Api.Custom
{
    public class TokenValidationInspector //: IDispatchMessageInspector
    {
        //public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        //{
        //    // Return BadRequest if request is null
        //    if (WebOperationContext.Current == null) { throw new WebFaultException(HttpStatusCode.BadRequest); }

        //    // Get Token from header
        //    var token = WebOperationContext.Current.IncomingRequest.Headers["Token"];

        //    // Validate the Token
        //    //using (var dbContext = new BasicTokenDbContext())
        //    {
        //        //ITokenValidator validator = new DatabaseTokenValidator(dbContext);
        //        //if (!validator.IsValid(token))
        //        //{
        //        //    throw new WebFaultException(HttpStatusCode.Forbidden);
        //        //}
        //        // Add User ids to the header so the service has them if needed
        //        WebOperationContext.Current.IncomingRequest.Headers.Add("User", "User......");
        //        WebOperationContext.Current.IncomingRequest.Headers.Add("UserId", "UserId.......");
        //    }
        //    return null;
        //}

        //public void BeforeSendReply(ref Message reply, object correlationState)
        //{
        //}
    }
    
}