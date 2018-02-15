using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
    public partial class CreateNewAlbumForm : Form
    {
        public User CurrentUser
        {
            get;
            set;
        }

        public CreateNewAlbumForm()
        {
            InitializeComponent();
        }

        private void createNewAlbumForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
        }

        private void createAlbumButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if(AlbumNameTextBox.Text != string.Empty)
            {
                Album newAlbum = CurrentUser.CreateAlbum(AlbumNameTextBox.Text, DescriptionTextBox.Text, PrivacyTextBox.Text);
                MessageBox.Show("The album created! Album id: " + newAlbum.Id, newAlbum.Name + " created");
                this.Close();
            }
            else
            {
                MessageBox.Show("You didn't insert the album's name.", "Error");
            }
        }

        private void createNewAlbumForm_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}