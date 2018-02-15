using System;
using System.Windows.Forms;

namespace MyFacebookApp
{
    public partial class PartnerZodiacSignForm : Form
    {
        private string m_PartnerSign = null;

        public string PartnerSign
        {
            get { return m_PartnerSign; }
        }

        public PartnerZodiacSignForm()
        {
            InitializeComponent();
        }

        private void capricornPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "capricorn";
            this.DialogResult = DialogResult.OK;
        }

        private void aquariusPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "aquarius";
            this.DialogResult = DialogResult.OK;
        }

        private void piscesPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "pisces";
            this.DialogResult = DialogResult.OK;
        }

        private void ariesPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "aries";
            this.DialogResult = DialogResult.OK;
        }

        private void taurusPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "taurus";
            this.DialogResult = DialogResult.OK;
        }

        private void geminiPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "gemini";
            this.DialogResult = DialogResult.OK;
        }

        private void cancerPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "cancer";
            this.DialogResult = DialogResult.OK;
        }

        private void leoPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "leo";
            this.DialogResult = DialogResult.OK;
        }

        private void virgoPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "virgo";
            this.DialogResult = DialogResult.OK;
        }

        private void libraPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "libra";
            this.DialogResult = DialogResult.OK;
        }

        private void scorpioPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "scorpio";
            this.DialogResult = DialogResult.OK;
        }

        private void sagittarusPictureBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_PartnerSign = "sagittarius";
            this.DialogResult = DialogResult.OK;
        }

        private void partnerSignFormForm_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void partnerSignFormForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
        }
    }
}