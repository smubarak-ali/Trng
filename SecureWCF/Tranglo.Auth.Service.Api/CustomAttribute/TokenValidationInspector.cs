using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services.Description;
using Tranglo.Auth.Services.Api.BL;

namespace Tranglo.Auth.Service.Api.CustomAttribute
{
    public class TokenValidationInspector : IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            // Return BadRequest if request is null
            if (WebOperationContext.Current == null) { throw new WebFaultException(HttpStatusCode.BadRequest); }

            // Get Token from header
            var token = WebOperationContext.Current.IncomingRequest.Headers["Token"];

            if (token != null)
            {
                // Decode the token and do the validation
                JsonWebToken jwtClass = new JsonWebToken();
                var decoded = jwtClass.Decode(token);
                WebOperationContext.Current.IncomingRequest.Headers.Add("User", "User......");
            }
            else
            {
                //throw new WebFaultException(HttpStatusCode.Unauthorized);
                return HttpStatusCode.Unauthorized;
            }
            //using (var dbContext = new BasicTokenDbContext())
            //{
            //    ITokenValidator validator = new DatabaseTokenValidator(dbContext);
            //    if (!validator.IsValid(token))
            //    {
            //        throw new WebFaultException(HttpStatusCode.Forbidden);
            //    }
            //    // Add User ids to the header so the service has them if needed
            //    WebOperationContext.Current.IncomingRequest.Headers.Add("User", "User......");
            //    WebOperationContext.Current.IncomingRequest.Headers.Add("UserId", "UserId.......");
            //}
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            //throw new NotImplementedException();
        }
    }
    
}