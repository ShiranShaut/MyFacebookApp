using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFacebookApp
{
    public partial class SetBirthdayForm : Form
    {
        private string m_UserBirthday;

        public string UserBirthday
        {
            get { return m_UserBirthday; }
        }

        public SetBirthdayForm()
        {
            InitializeComponent();
        }

        private void setBirthdayForm_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void setBirthdayForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
        }

        private void setBirthdayButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_UserBirthday = BirthdayDateTimePicker.Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
