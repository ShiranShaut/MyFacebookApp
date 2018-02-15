namespace MyFacebookApp
{
    public partial class PlaylistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Facebook Posts");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Playlist");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            this.PlaylistTreeView = new System.Windows.Forms.TreeView();
            this.SelectedPlaylistWebBrowser = new System.Windows.Forms.WebBrowser();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.RemoveSongButton = new System.Windows.Forms.Button();
            this.NewSongNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayersGroupBox = new System.Windows.Forms.GroupBox();
            this.YoutubeRadioButton = new System.Windows.Forms.RadioButton();
            this.VimeoRadioButton = new System.Windows.Forms.RadioButton();
            this.PostSongButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlayersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaylistTreeView
            // 
            this.PlaylistTreeView.Location = new System.Drawing.Point(13, 5);
            this.PlaylistTreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlaylistTreeView.Name = "PlaylistTreeView";
            treeNode1.Name = "FacebookNode";
            treeNode1.Text = "Facebook Posts";
            treeNode1.ToolTipText = "Your linked videos you post on facebook";
            treeNode2.Name = "UserNameNode";
            treeNode2.Text = "User Playlist";
            this.PlaylistTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.PlaylistTreeView.Size = new System.Drawing.Size(334, 229);
            this.PlaylistTreeView.TabIndex = 0;
            this.PlaylistTreeView.DoubleClick += new System.EventHandler(this.playlistTreeView_DoubleClick);
            // 
            // SelectedPlaylistWebBrowser
            // 
            this.SelectedPlaylistWebBrowser.Location = new System.Drawing.Point(355, 5);
            this.SelectedPlaylistWebBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectedPlaylistWebBrowser.MinimumSize = new System.Drawing.Size(27, 35);
            this.SelectedPlaylistWebBrowser.Name = "SelectedPlaylistWebBrowser";
            this.SelectedPlaylistWebBrowser.ScriptErrorsSuppressed = true;
            this.SelectedPlaylistWebBrowser.Size = new System.Drawing.Size(491, 345);
            this.SelectedPlaylistWebBrowser.TabIndex = 1;
            // 
            // AddSongButton
            // 
            this.AddSongButton.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.AddSongButton.Location = new System.Drawing.Point(190, 322);
            this.AddSongButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(124, 34);
            this.AddSongButton.TabIndex = 2;
            this.AddSongButton.Text = "Add Song";
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // RemoveSongButton
            // 
            this.RemoveSongButton.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.RemoveSongButton.Location = new System.Drawing.Point(190, 361);
            this.RemoveSongButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveSongButton.Name = "RemoveSongButton";
            this.RemoveSongButton.Size = new System.Drawing.Size(124, 34);
            this.RemoveSongButton.TabIndex = 3;
            this.RemoveSongButton.Text = "Remove Song";
            this.RemoveSongButton.UseVisualStyleBackColor = true;
            this.RemoveSongButton.Click += new System.EventHandler(this.removeSongButton_Click);
            // 
            // NewSongNameTextBox
            // 
            this.NewSongNameTextBox.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.NewSongNameTextBox.Location = new System.Drawing.Point(13, 322);
            this.NewSongNameTextBox.Name = "NewSongNameTextBox";
            this.NewSongNameTextBox.Size = new System.Drawing.Size(169, 29);
            this.NewSongNameTextBox.TabIndex = 7;
            this.NewSongNameTextBox.Text = "Enter song name";
            this.NewSongNameTextBox.Click += new System.EventHandler(this.newSongNameTextBox_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(377, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "Press double click on song to watch him";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(357, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // PlayersGroupBox
            // 
            this.PlayersGroupBox.Controls.Add(this.YoutubeRadioButton);
            this.PlayersGroupBox.Controls.Add(this.VimeoRadioButton);
            this.PlayersGroupBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersGroupBox.ForeColor = System.Drawing.Color.Black;
            this.PlayersGroupBox.Location = new System.Drawing.Point(13, 242);
            this.PlayersGroupBox.Name = "PlayersGroupBox";
            this.PlayersGroupBox.Size = new System.Drawing.Size(169, 74);
            this.PlayersGroupBox.TabIndex = 27;
            this.PlayersGroupBox.TabStop = false;
            this.PlayersGroupBox.Text = "Choose Player:";
            // 
            // YoutubeRadioButton
            // 
            this.YoutubeRadioButton.AutoSize = true;
            this.YoutubeRadioButton.Checked = true;
            this.YoutubeRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoutubeRadioButton.Location = new System.Drawing.Point(6, 19);
            this.YoutubeRadioButton.Name = "YoutubeRadioButton";
            this.YoutubeRadioButton.Size = new System.Drawing.Size(84, 27);
            this.YoutubeRadioButton.TabIndex = 5;
            this.YoutubeRadioButton.TabStop = true;
            this.YoutubeRadioButton.Text = "YouTube";
            this.YoutubeRadioButton.UseVisualStyleBackColor = true;
            // 
            // VimeoRadioButton
            // 
            this.VimeoRadioButton.AutoSize = true;
            this.VimeoRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VimeoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.VimeoRadioButton.Name = "VimeoRadioButton";
            this.VimeoRadioButton.Size = new System.Drawing.Size(68, 27);
            this.VimeoRadioButton.TabIndex = 6;
            this.VimeoRadioButton.Text = "Vimeo";
            this.VimeoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PostSongButton
            // 
            this.PostSongButton.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.PostSongButton.Location = new System.Drawing.Point(13, 361);
            this.PostSongButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostSongButton.Name = "PostSongButton";
            this.PostSongButton.Size = new System.Drawing.Size(169, 34);
            this.PostSongButton.TabIndex = 28;
            this.PostSongButton.Text = "Post song on facebook";
            this.PostSongButton.UseVisualStyleBackColor = true;
            this.PostSongButton.Click += new System.EventHandler(this.postSongButton_Click);
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 406);
            this.Controls.Add(this.PostSongButton);
            this.Controls.Add(this.PlayersGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewSongNameTextBox);
            this.Controls.Add(this.RemoveSongButton);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.SelectedPlaylistWebBrowser);
            this.Controls.Add(this.PlaylistTreeView);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playlistForm_FormClosing);
            this.Load += new System.EventHandler(this.playlistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlayersGroupBox.ResumeLayout(false);
            this.PlayersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView PlaylistTreeView;
        private System.Windows.Forms.WebBrowser SelectedPlaylistWebBrowser;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Button RemoveSongButton;
        private System.Windows.Forms.TextBox NewSongNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PlayersGroupBox;
        private System.Windows.Forms.RadioButton YoutubeRadioButton;
        private System.Windows.Forms.RadioButton VimeoRadioButton;
        private System.Windows.Forms.Button PostSongButton;
    }
}