using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using PlaylistController;

namespace MyFacebookApp
{
    public partial class PlaylistForm : Form
    {
        private FacebookObjectCollection<Link> m_UserLinks;
        public User m_LoggedInUser;

        public FacebookObjectCollection<Link> UserLinks
        {
            get { return m_UserLinks; }
            set { m_UserLinks = value; }
        }

        public PlaylistForm()
        {
            InitializeComponent();
            SelectedPlaylistWebBrowser.WebBrowserShortcutsEnabled = false;
        }

        private void playlistForm_Load(object i_Sender, EventArgs i_EventArgs)
        {
            this.CenterToScreen();
            PlaylistTreeView.Nodes[1].Text = m_LoggedInUser.FirstName + "'s Playlist";
        }

        protected override void OnShown(EventArgs i_EventArgs)
        {
            new Thread(fetchUserLinkes).Start();
        }

        private void fetchUserLinkes()
        {
            foreach (Link curLink in m_UserLinks)
            {
                try
                {
                    Song song = SongsFactory.CreateSong(curLink.URL, curLink.Name);

                    if (!PlaylistTreeView.InvokeRequired)
                    {
                        addSongToTreeView(song);
                    }
                    else
                    {
                        PlaylistTreeView.Invoke(new Action(() => addSongToTreeView(song))); // save the song under song's name));
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void addSongToTreeView(Song i_Song)
        {
            TreeNode songNode = PlaylistTreeView.Nodes[0].Nodes.Add(i_Song.SongName); // Nodes[0]=Facebook Posts

            songNode.Tag = i_Song;
        }

        private void playlistForm_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void playlistTreeView_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            TreeNode curNode = PlaylistTreeView.SelectedNode;

            try
            {
                SelectedPlaylistWebBrowser.Url = new Uri(((Song)curNode.Tag).SongLink);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(
@"There isn't link to that song,
Please try another song.",
                         "Error");
            }
        }

        private void addSongButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            Song curSong = null;
            string curPlayer = null;

            if (!string.IsNullOrEmpty(NewSongNameTextBox.Text))
            {
                if (YoutubeRadioButton.Checked)
                {
                    curPlayer = "youtube";
                }
                else
                {
                    curPlayer = "vimeo";
                }

                curSong = SongsFactory.CreateSong(curPlayer, NewSongNameTextBox.Text);
                string videoUrl = curSong.GetVideoUrl(NewSongNameTextBox.Text);
                TreeNode songNode = PlaylistTreeView.Nodes[1].Nodes.Add(curSong.SongName); // Nodes[1]=User Playlist

                songNode.Tag = curSong;
                MessageBox.Show(string.Format("The song: \"{0}\" added to your playlist!", NewSongNameTextBox.Text));
                NewSongNameTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("You didn't insert song name!");
            }
        }

        private void removeSongButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (PlaylistTreeView.Nodes[1].Nodes.Count > 0)
            {
                PlaylistTreeView.Nodes[1].Nodes.Remove(PlaylistTreeView.SelectedNode);
            }
            else
            {
                MessageBox.Show("There isn't songs in your playlist.");
            }
        }

        private void postSongButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            TreeNode curNode = PlaylistTreeView.SelectedNode;

            try
            {
                string songUrl = new Uri(((Song)curNode.Tag).SongLink).ToString();
                Link link = m_LoggedInUser.PostLink(songUrl, string.Empty);
                MessageBox.Show("Song posted! id:" + link.Id, curNode.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to choose song from playlist", "Error occurred");
            }
        }

        private void newSongNameTextBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            NewSongNameTextBox.Text = string.Empty;
            NewSongNameTextBox.Click -= new System.EventHandler(this.newSongNameTextBox_Click);
        }
    }
}