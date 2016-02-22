using STS.Contants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace STS.BL
{
    class STSServiceHostFactory : ServiceHostFactory
    {
        private static Binding STSBinding
        {
            get
            {
                return new WS2007HttpBinding("STS-WS2007HttpBinding");
            }
        }

        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            string issuerName = WebConfigurationManager.AppSettings[Common.IssuerName];
            string signingCertificateThumprint = WebConfigurationManager.AppSettings[Common.SigningCertificateThumbprint];
            string issuerCertificateThumprint = WebConfigurationManager.AppSettings[Common.IssuerCertificateThumprint];
            var config = new STSConfiguration(issuerName, signingCertificateThumprint, issuerCertificateThumprint);
            
            //this baseUri can be set to Uri.UriSchemeHttps
            Uri baseUri = baseAddresses.FirstOrDefault(a => a.Scheme == Uri.UriSchemeHttps);

            if (baseUri == null)
            {
                throw new InvalidOperationException("The STS should be hosted under https.");
            }

            WSTrustServiceHost host = new WSTrustServiceHost(config, baseAddresses);
            host.AddServiceEndpoint(typeof(IWSTrust13SyncContract), STSBinding, baseUri.AbsoluteUri);
            return host;
        }
    }
}
