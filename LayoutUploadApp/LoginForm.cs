using LayoutUploadApp.Services;

namespace LayoutUploadApp
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly UploadLayoutFrom uploadLayoutFrom;
        public LoginForm(IAuthService authService, UploadLayoutFrom uploadLayoutFrom)
        {
            _authService = authService;
            this.uploadLayoutFrom = uploadLayoutFrom;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Default.Identifier))
            {
                IdentitfierTxt.Show();
            }
            else
            {
                IdentitfierTxt.Hide();
            }
        }

        private async void LoginBtn_ClickAsync(object sender, EventArgs e)
        {
            LoginErrorProvider.Clear();
            if (ValidateForm())
            {
                try
                {
                    await GlobalSetting.ProgressLoading(LoginProgress, LoginBtn, UserNameTxt, PasswordTxt, IdentitfierTxt);

                    string identifier = IdentitfierTxt.Visible ? IdentitfierTxt.Text : Settings.Default.Identifier;

                    var token = await _authService.LoginAsync(UserNameTxt.Text, PasswordTxt.Text, identifier);
                    if (!string.IsNullOrEmpty(token))
                    {
                        GlobalSetting.AuthToken = token;
                        this.Hide();
                        uploadLayoutFrom.Show();
                        uploadLayoutFrom.FormClosed += (s, args) => this.Close();
                        if (!string.IsNullOrEmpty(IdentitfierTxt.Text))
                        {
                            Settings.Default.Identifier = IdentitfierTxt.Text;
                            Settings.Default.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username,password or identitfier.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error happened please try again later", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await GlobalSetting.ProgressStop(LoginProgress, LoginBtn, UserNameTxt, PasswordTxt, IdentitfierTxt);
                }
                finally
                {
                    await GlobalSetting.ProgressStop(LoginProgress, LoginBtn, UserNameTxt, PasswordTxt, IdentitfierTxt);
                }
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(UserNameTxt.Text))
            {
                LoginErrorProvider.SetError(UserNameTxt, "User Name is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                LoginErrorProvider.SetError(PasswordTxt, "Password is required");
                isValid = false;
            }
            if (IdentitfierTxt.Visible && string.IsNullOrEmpty(IdentitfierTxt.Text))
            {
                LoginErrorProvider.SetError(IdentitfierTxt, "Identitfier is required");
                isValid = false;
            }
            return isValid;
        }
    }
}
