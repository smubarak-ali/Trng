using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
        List<Type> MyAttributes = new List<Type>() { typeof(TokenValidationServiceBehavior) };

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            // Return BadRequest if request is null
            if (WebOperationContext.Current == null) 
            { 
                throw new WebFaultException(HttpStatusCode.BadRequest);
            }

            //initialization params;
            bool needsAuthorized = true;

            // Get Token from header
            var token = WebOperationContext.Current.IncomingRequest.Headers["Token"];
            
            if (token != null)
            {
                UserAccessAttribute myAttr = new UserAccessAttribute();

                #region get the attributes
                var serviceType = instanceContext.Host.Description.ServiceType;
                var operationName = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.RequestUri.AbsoluteUri;
                var methodName = operationName.Substring(operationName.LastIndexOf("/") + 1);

                var method = serviceType.GetMethods().Where(m => m.Name == methodName && m.IsPublic).SingleOrDefault();
                var attributes = method.GetCustomAttributes(typeof(UserAccessAttribute)); //Where(a => MyAttributes.Contains(a.GetType()));
                foreach (Attribute attr in attributes)
                {
                    if (attr is UserAccessAttribute)
                    {
                        myAttr = (UserAccessAttribute)attr;
                        needsAuthorized = myAttr.IsAuthenticationRequired();

                    }//if
                }//foreach
                #endregion get the attributes

                if (needsAuthorized == true)
                {
                    // Decode the token and do the validation
                    JsonWebToken jwtClass = new JsonWebToken();
                    var decoded = jwtClass.Decode(token);
                    var tokenObj = JsonConvert.DeserializeObject<Token>(decoded);

                    if(tokenObj.Role.ToLower().Equals(myAttr.GetRole().ToLower()))
                    {
                        WebOperationContext.Current.IncomingRequest.Headers.Add("Username", tokenObj.Username);
                        WebOperationContext.Current.IncomingRequest.Headers.Add("Role", tokenObj.Role);
                    }
                    else
                    {
                        throw new WebFaultException(HttpStatusCode.Forbidden);
                    }
                }
            }
            else
            {
                throw new WebFaultException(HttpStatusCode.Unauthorized);
                //return HttpStatusCode.Unauthorized;
            }
            
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            //throw new NotImplementedException();
        }
    }
    
}