using System;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Windows.Forms;
using STS.RelyingPartyApp.SampleServiceOne;
using SampleServiceApi;

namespace STS.RelyingPartyApp
{
    public partial class Main : Form
    {
        private readonly AuthController _authController = new AuthController();

        public Main()
        {
            InitializeComponent();
        }

        private void Login(string userName, string userPassword)
        {
            try
            {
                _authController.Login(userName, userPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ViewClaims();
        }

        private void Logout()
        {
            _authController.Logout();
            ViewClaims();
        }

        private void ViewClaims()
        {
            rtbClaims.Clear();
            rtbClaims.Text = "Not logged.";
            chbIsAdmin.Checked = chbIsSuperAdmin.Checked = chbIsUser.Checked = false;
            if (_authController.isAuthenticated())
            {
                var identity = _authController.UserIdenity;
                var sb = new StringBuilder();
                foreach (var claim in identity.Claims)
                {
                    sb.AppendFormat("Claim:{0} Value:{1}", claim.Type, claim.Value);
                    sb.AppendLine();
                }
                rtbClaims.Text = sb.ToString();
                chbIsAdmin.Checked = identity.IsInRole("Admin");
                chbIsSuperAdmin.Checked = identity.IsInRole("SuperAdmin");
                chbIsUser.Checked = identity.IsInRole("User");
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (ValidateUserCredentials())
            {
                Login(txtLogin.Text, txtPassword.Text);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private bool ValidateUserCredentials()
        {
            const string error = "Can't be empty!";
            var result = true;
            errProv.SetError(txtLogin, string.Empty);
            errProv.SetError(txtLogin, string.Empty);
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errProv.SetError(txtPassword, error);
                txtPassword.Focus();
                result = false;
            }
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                errProv.SetError(txtLogin, error);
                txtLogin.Focus();
                result = false;
            }

            return result;
        }


        private void btnServiceOne_Click(object sender, EventArgs e)
        {
            rtbClaims.Clear();
            var request = "Test";
            using (var serviceApi = new ServiceApiFactory(_authController.GeToken()))
            {
                rtbClaims.AppendText("Call to Service One:");
                var client = serviceApi.GetService<ISampleServiceOne>("WS2007FederationHttpBinding_ISampleServiceOne");
                try
                {
                    rtbClaims.AppendText("Method ComputeResponse");
                    var response = client.ComputeResponse(request);
                    rtbClaims.AppendText(response);
                    rtbClaims.AppendText("Method ComputeResponseAdmin");
                    response = client.ComputeResponseAdmin(request);
                    rtbClaims.AppendText(response);
                    rtbClaims.AppendText("Method ComputeResponseSuperAdmin");
                    response = client.ComputeResponseSuperAdmin(request);
                    rtbClaims.AppendText(response);
                }
                catch (SecurityAccessDeniedException ex)
                {
                    rtbClaims.AppendText(Environment.NewLine);
                    rtbClaims.AppendText(string.Format("ERROR:{0}", ex.Message));
                }
            }
        }

        private void btnServiceTwo_Click(object sender, EventArgs e)
        {
            rtbClaims.Clear();
            var request = "Test";
            using (var serviceApi = new ServiceApiFactory(_authController.GeToken()))
            {
                //rtbClaims.AppendText("Call to Service Two:");
                //var client = serviceApi.GetService<ISampleServiceTwo>("WS2007FederationHttpBinding_ISampleServiceTwo");
                //try
                //{
                //    rtbClaims.AppendText("Method ComputeResponse");
                //    var response = client.ComputeResponse(request);
                //    rtbClaims.AppendText(response);
                //    rtbClaims.AppendText("Method ComputeResponseAdmin");
                //    response = client.ComputeResponseAdmin(request);
                //    rtbClaims.AppendText(response);
                //    rtbClaims.AppendText("Method ComputeResponseSuperAdmin");
                //    response = client.ComputeResponseSuperAdmin(request);
                //    rtbClaims.AppendText(response);
                //}
                //catch (MessageSecurityException ex)
                //{
                //    rtbClaims.AppendText(Environment.NewLine);
                //    rtbClaims.AppendText(string.Format("ERROR:{0}", ex.InnerException != null
                //        ? ex.InnerException.Message
                //        : ex.Message));
                //}
                //catch (FaultException ex)
                //{
                //    rtbClaims.AppendText(Environment.NewLine);
                //    rtbClaims.AppendText(string.Format("ERROR:{0}", ex.Message));
                //}
            }
        }
    }
}