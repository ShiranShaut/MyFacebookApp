using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace MyFacebookApp
{
    public partial class LoginForm : Form
    {
        private readonly string[] r_RequiredPermissions =
        {
            "public_profile",
            "user_friends",
            "publish_actions",
            "user_events",
            "user_posts",
            "user_photos",
            "user_status",
            "user_birthday",
            "user_location",
            "user_relationships",
            "user_relationship_details",
            "email"
        };

        private LoginResult m_loginResult = new LoginResult();
        private string m_AppId = "124939601605338"; // our AppId - defult value
        
        public LoginResult LoginResult
        {
            get { return m_loginResult; }
        }

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            AppIdComboBox.SelectedIndex = 1;
        }
        
        private void loginButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_AppId = AppIdComboBox.SelectedItem.ToString().Split(new char[] { '-' })[1];
            m_loginResult = FacebookService.Login(m_AppId, r_RequiredPermissions);

            if (!string.IsNullOrEmpty(m_loginResult.AccessToken))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                try
                {
                    MessageBox.Show(m_loginResult.ErrorMessage, "Login Error");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("You didn't login", "Login Error");
                }
            }
        }

        private void loginForm_FormClosed(object i_Sender, FormClosedEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}