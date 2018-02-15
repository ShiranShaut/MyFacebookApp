namespace MyFacebookApp
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label endTimeLabel1;
            System.Windows.Forms.Label startTimeLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.EventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EventsGroupBox = new System.Windows.Forms.GroupBox();
            this.NotRepliedRadioButton = new System.Windows.Forms.RadioButton();
            this.AttendingRadioButton = new System.Windows.Forms.RadioButton();
            this.MaybeRadioButton = new System.Windows.Forms.RadioButton();
            this.NotAttendingRadioButton = new System.Windows.Forms.RadioButton();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.CheckInsTab = new System.Windows.Forms.TabPage();
            this.ShowCheckInsButton = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.HoroscopeTab = new System.Windows.Forms.TabPage();
            this.SignPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectsPartnerButton = new System.Windows.Forms.Button();
            this.GetMathcesButton = new System.Windows.Forms.Button();
            this.FetchHoroscopeButton = new System.Windows.Forms.Button();
            this.ZodiacSignLabel = new System.Windows.Forms.Label();
            this.HoroscopeTextBox = new System.Windows.Forms.TextBox();
            this.HoroscopeBirthdayLabel = new System.Windows.Forms.Label();
            this.PlaylistTabPage = new System.Windows.Forms.TabPage();
            this.GetPlaylistButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Notes1PictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.AlbumsPanel = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlbumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CreateAlbumButton = new System.Windows.Forms.Button();
            this.FetchAlbumsButton = new System.Windows.Forms.Button();
            this.AlbumsOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.PostsTab = new System.Windows.Forms.TabPage();
            this.FetchPostsButton = new System.Windows.Forms.Button();
            this.PostsListBox = new System.Windows.Forms.ListBox();
            this.FriendListTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.FriendsLastNameOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.FetchFriendButton = new System.Windows.Forms.Button();
            this.FriendsFirstNameOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FriendCheckedPictureBox = new System.Windows.Forms.PictureBox();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.LikedPagesTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.FetchLikedPagesButton = new System.Windows.Forms.Button();
            this.LikedPagesInOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LikedPagePictureBox = new System.Windows.Forms.PictureBox();
            this.LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.GetInTouchTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GetInThouchPictureBox = new System.Windows.Forms.PictureBox();
            this.Hearts2PictureBox = new System.Windows.Forms.PictureBox();
            this.HeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.SingelsFriendsListBox = new System.Windows.Forms.ListBox();
            this.FetchSingelsFriendsButton = new System.Windows.Forms.Button();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.UserBirthdayLabel = new System.Windows.Forms.Label();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.UserLivesInLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.PostStatusButton = new System.Windows.Forms.Button();
            this.UserInterestedInLabel = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UiDateHLabel = new System.Windows.Forms.Label();
            this.TimeUILabel = new System.Windows.Forms.Label();
            this.DateUiLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HBIrthdayLlabel = new System.Windows.Forms.Label();
            this.UserProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.CoverPictureBox = new System.Windows.Forms.PictureBox();
            descriptionLabel1 = new System.Windows.Forms.Label();
            endTimeLabel1 = new System.Windows.Forms.Label();
            startTimeLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            this.UserTabControl.SuspendLayout();
            this.EventsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EventsGroupBox.SuspendLayout();
            this.CheckInsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.HoroscopeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignPictureBox)).BeginInit();
            this.PlaylistTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes1PictureBox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            this.AlbumsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.PostsTab.SuspendLayout();
            this.FriendListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendCheckedPictureBox)).BeginInit();
            this.LikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).BeginInit();
            this.GetInTouchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInThouchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(5, 149);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(82, 21);
            descriptionLabel1.TabIndex = 0;
            descriptionLabel1.Text = "Description:";
            // 
            // endTimeLabel1
            // 
            endTimeLabel1.AutoSize = true;
            endTimeLabel1.Location = new System.Drawing.Point(6, 122);
            endTimeLabel1.Name = "endTimeLabel1";
            endTimeLabel1.Size = new System.Drawing.Size(72, 21);
            endTimeLabel1.TabIndex = 2;
            endTimeLabel1.Text = "End Time:";
            // 
            // startTimeLabel1
            // 
            startTimeLabel1.AutoSize = true;
            startTimeLabel1.Location = new System.Drawing.Point(5, 94);
            startTimeLabel1.Name = "startTimeLabel1";
            startTimeLabel1.Size = new System.Drawing.Size(81, 21);
            startTimeLabel1.TabIndex = 6;
            startTimeLabel1.Text = "Start Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(95, 21);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Event Owner:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(10, 81);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(105, 23);
            createdTimeLabel.TabIndex = 27;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 111);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(89, 23);
            descriptionLabel.TabIndex = 29;
            descriptionLabel.Text = "Description:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Location = new System.Drawing.Point(74, 22);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(0, 23);
            imageAlbumLabel.TabIndex = 31;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(139, 199);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(36, 42);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "...";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(829, 330);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(116, 37);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.EventsTab);
            this.UserTabControl.Controls.Add(this.CheckInsTab);
            this.UserTabControl.Controls.Add(this.HoroscopeTab);
            this.UserTabControl.Controls.Add(this.PlaylistTabPage);
            this.UserTabControl.Controls.Add(this.AlbumsTab);
            this.UserTabControl.Controls.Add(this.PostsTab);
            this.UserTabControl.Controls.Add(this.FriendListTab);
            this.UserTabControl.Controls.Add(this.LikedPagesTab);
            this.UserTabControl.Controls.Add(this.GetInTouchTab);
            this.UserTabControl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTabControl.Location = new System.Drawing.Point(1, 381);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(978, 285);
            this.UserTabControl.TabIndex = 3;
            // 
            // EventsTab
            // 
            this.EventsTab.AutoScroll = true;
            this.EventsTab.BackColor = System.Drawing.Color.Snow;
            this.EventsTab.Controls.Add(this.panel1);
            this.EventsTab.Controls.Add(this.label1);
            this.EventsTab.Controls.Add(this.pictureBox1);
            this.EventsTab.Controls.Add(this.EventsGroupBox);
            this.EventsTab.Controls.Add(this.EventsListBox);
            this.EventsTab.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.EventsTab.Location = new System.Drawing.Point(4, 35);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventsTab.Size = new System.Drawing.Size(970, 246);
            this.EventsTab.TabIndex = 0;
            this.EventsTab.Text = "Events";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(descriptionLabel1);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(endTimeLabel1);
            this.panel1.Controls.Add(this.endTimeDateTimePicker);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(startTimeLabel1);
            this.panel1.Controls.Add(this.startTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 232);
            this.panel1.TabIndex = 25;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EventBindingSource, "Owner.Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(96, 68);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(162, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "[Owner Name]";
            // 
            // EventBindingSource
            // 
            this.EventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(7, 174);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(316, 51);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.EventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Office Preview Font", 8.25F);
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(98, 122);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.EventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(8, 6);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(69, 61);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.EventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Office Preview Font", 8.25F);
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(98, 94);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.startTimeDateTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(766, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Press on event from list to see details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(746, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // EventsGroupBox
            // 
            this.EventsGroupBox.Controls.Add(this.NotRepliedRadioButton);
            this.EventsGroupBox.Controls.Add(this.AttendingRadioButton);
            this.EventsGroupBox.Controls.Add(this.MaybeRadioButton);
            this.EventsGroupBox.Controls.Add(this.NotAttendingRadioButton);
            this.EventsGroupBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.EventsGroupBox.Location = new System.Drawing.Point(745, 15);
            this.EventsGroupBox.Name = "EventsGroupBox";
            this.EventsGroupBox.Size = new System.Drawing.Size(184, 118);
            this.EventsGroupBox.TabIndex = 22;
            this.EventsGroupBox.TabStop = false;
            this.EventsGroupBox.Text = "Choose Events To Show:";
            // 
            // NotRepliedRadioButton
            // 
            this.NotRepliedRadioButton.AutoSize = true;
            this.NotRepliedRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotRepliedRadioButton.Location = new System.Drawing.Point(6, 88);
            this.NotRepliedRadioButton.Name = "NotRepliedRadioButton";
            this.NotRepliedRadioButton.Size = new System.Drawing.Size(154, 27);
            this.NotRepliedRadioButton.TabIndex = 8;
            this.NotRepliedRadioButton.Text = "Not Replied Events";
            this.NotRepliedRadioButton.UseVisualStyleBackColor = true;
            this.NotRepliedRadioButton.Click += new System.EventHandler(this.notRepliedRadioButton_Click);
            // 
            // AttendingRadioButton
            // 
            this.AttendingRadioButton.AutoSize = true;
            this.AttendingRadioButton.Checked = true;
            this.AttendingRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AttendingRadioButton.Name = "AttendingRadioButton";
            this.AttendingRadioButton.Size = new System.Drawing.Size(144, 27);
            this.AttendingRadioButton.TabIndex = 5;
            this.AttendingRadioButton.TabStop = true;
            this.AttendingRadioButton.Text = "Attending Events";
            this.AttendingRadioButton.UseVisualStyleBackColor = true;
            this.AttendingRadioButton.Click += new System.EventHandler(this.attendingRadioButton_Click);
            // 
            // MaybeRadioButton
            // 
            this.MaybeRadioButton.AutoSize = true;
            this.MaybeRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaybeRadioButton.Location = new System.Drawing.Point(6, 65);
            this.MaybeRadioButton.Name = "MaybeRadioButton";
            this.MaybeRadioButton.Size = new System.Drawing.Size(120, 27);
            this.MaybeRadioButton.TabIndex = 7;
            this.MaybeRadioButton.Text = "Maybe Events";
            this.MaybeRadioButton.UseVisualStyleBackColor = true;
            this.MaybeRadioButton.Click += new System.EventHandler(this.maybeRadioButton_Click);
            // 
            // NotAttendingRadioButton
            // 
            this.NotAttendingRadioButton.AutoSize = true;
            this.NotAttendingRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAttendingRadioButton.Location = new System.Drawing.Point(6, 42);
            this.NotAttendingRadioButton.Name = "NotAttendingRadioButton";
            this.NotAttendingRadioButton.Size = new System.Drawing.Size(173, 27);
            this.NotAttendingRadioButton.TabIndex = 6;
            this.NotAttendingRadioButton.Text = "Not Attending Events";
            this.NotAttendingRadioButton.UseVisualStyleBackColor = true;
            this.NotAttendingRadioButton.Click += new System.EventHandler(this.notAttendingRadioButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.DataSource = this.EventBindingSource;
            this.EventsListBox.DisplayMember = "Name";
            this.EventsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 23;
            this.EventsListBox.Location = new System.Drawing.Point(350, 6);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(377, 234);
            this.EventsListBox.TabIndex = 0;
            // 
            // CheckInsTab
            // 
            this.CheckInsTab.BackColor = System.Drawing.Color.Snow;
            this.CheckInsTab.Controls.Add(this.ShowCheckInsButton);
            this.CheckInsTab.Controls.Add(this.pictureBox7);
            this.CheckInsTab.Location = new System.Drawing.Point(4, 35);
            this.CheckInsTab.Name = "CheckInsTab";
            this.CheckInsTab.Size = new System.Drawing.Size(970, 246);
            this.CheckInsTab.TabIndex = 3;
            this.CheckInsTab.Text = "Check Ins";
            // 
            // ShowCheckInsButton
            // 
            this.ShowCheckInsButton.BackColor = System.Drawing.Color.Black;
            this.ShowCheckInsButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCheckInsButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ShowCheckInsButton.Location = new System.Drawing.Point(342, 18);
            this.ShowCheckInsButton.Name = "ShowCheckInsButton";
            this.ShowCheckInsButton.Size = new System.Drawing.Size(304, 36);
            this.ShowCheckInsButton.TabIndex = 10;
            this.ShowCheckInsButton.Text = "Show Locations On Map";
            this.ShowCheckInsButton.UseVisualStyleBackColor = false;
            this.ShowCheckInsButton.Click += new System.EventHandler(this.showCheckInsButton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MyFacebookApp.Properties.Resources.checkinsphoto;
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(964, 240);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // HoroscopeTab
            // 
            this.HoroscopeTab.BackColor = System.Drawing.Color.White;
            this.HoroscopeTab.Controls.Add(this.SignPictureBox);
            this.HoroscopeTab.Controls.Add(this.SelectsPartnerButton);
            this.HoroscopeTab.Controls.Add(this.GetMathcesButton);
            this.HoroscopeTab.Controls.Add(this.FetchHoroscopeButton);
            this.HoroscopeTab.Controls.Add(this.ZodiacSignLabel);
            this.HoroscopeTab.Controls.Add(this.HoroscopeTextBox);
            this.HoroscopeTab.Controls.Add(this.HoroscopeBirthdayLabel);
            this.HoroscopeTab.Location = new System.Drawing.Point(4, 35);
            this.HoroscopeTab.Name = "HoroscopeTab";
            this.HoroscopeTab.Size = new System.Drawing.Size(970, 246);
            this.HoroscopeTab.TabIndex = 6;
            this.HoroscopeTab.Text = "Horoscope";
            // 
            // SignPictureBox
            // 
            this.SignPictureBox.Location = new System.Drawing.Point(790, 12);
            this.SignPictureBox.Name = "SignPictureBox";
            this.SignPictureBox.Size = new System.Drawing.Size(84, 87);
            this.SignPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignPictureBox.TabIndex = 13;
            this.SignPictureBox.TabStop = false;
            // 
            // SelectsPartnerButton
            // 
            this.SelectsPartnerButton.BackColor = System.Drawing.Color.Pink;
            this.SelectsPartnerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(128)))));
            this.SelectsPartnerButton.Location = new System.Drawing.Point(726, 152);
            this.SelectsPartnerButton.Name = "SelectsPartnerButton";
            this.SelectsPartnerButton.Size = new System.Drawing.Size(213, 36);
            this.SelectsPartnerButton.TabIndex = 12;
            this.SelectsPartnerButton.Text = "Select Partner Sign";
            this.SelectsPartnerButton.UseVisualStyleBackColor = false;
            this.SelectsPartnerButton.Click += new System.EventHandler(this.selectsPartnerButton_Click);
            // 
            // GetMathcesButton
            // 
            this.GetMathcesButton.BackColor = System.Drawing.Color.Pink;
            this.GetMathcesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(128)))));
            this.GetMathcesButton.Location = new System.Drawing.Point(726, 199);
            this.GetMathcesButton.Name = "GetMathcesButton";
            this.GetMathcesButton.Size = new System.Drawing.Size(213, 36);
            this.GetMathcesButton.TabIndex = 11;
            this.GetMathcesButton.Text = "Get Your Matches";
            this.GetMathcesButton.UseVisualStyleBackColor = false;
            this.GetMathcesButton.Click += new System.EventHandler(this.getMathcesButton_Click);
            // 
            // FetchHoroscopeButton
            // 
            this.FetchHoroscopeButton.BackColor = System.Drawing.Color.Pink;
            this.FetchHoroscopeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(128)))));
            this.FetchHoroscopeButton.Location = new System.Drawing.Point(726, 105);
            this.FetchHoroscopeButton.Name = "FetchHoroscopeButton";
            this.FetchHoroscopeButton.Size = new System.Drawing.Size(213, 36);
            this.FetchHoroscopeButton.TabIndex = 10;
            this.FetchHoroscopeButton.Text = "Fetch daily horoscope";
            this.FetchHoroscopeButton.UseVisualStyleBackColor = false;
            this.FetchHoroscopeButton.Click += new System.EventHandler(this.fetchHoroscopeButton_Click);
            // 
            // ZodiacSignLabel
            // 
            this.ZodiacSignLabel.AutoSize = true;
            this.ZodiacSignLabel.Font = new System.Drawing.Font("Segoe Print", 12.5F);
            this.ZodiacSignLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ZodiacSignLabel.Location = new System.Drawing.Point(349, 12);
            this.ZodiacSignLabel.Name = "ZodiacSignLabel";
            this.ZodiacSignLabel.Size = new System.Drawing.Size(135, 30);
            this.ZodiacSignLabel.TabIndex = 9;
            this.ZodiacSignLabel.Text = "Zodiac sign: ...";
            // 
            // HoroscopeTextBox
            // 
            this.HoroscopeTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoroscopeTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.HoroscopeTextBox.ForeColor = System.Drawing.Color.DeepPink;
            this.HoroscopeTextBox.Location = new System.Drawing.Point(12, 53);
            this.HoroscopeTextBox.Multiline = true;
            this.HoroscopeTextBox.Name = "HoroscopeTextBox";
            this.HoroscopeTextBox.ReadOnly = true;
            this.HoroscopeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HoroscopeTextBox.Size = new System.Drawing.Size(702, 185);
            this.HoroscopeTextBox.TabIndex = 8;
            // 
            // HoroscopeBirthdayLabel
            // 
            this.HoroscopeBirthdayLabel.AutoSize = true;
            this.HoroscopeBirthdayLabel.Font = new System.Drawing.Font("Segoe Print", 12.5F);
            this.HoroscopeBirthdayLabel.ForeColor = System.Drawing.Color.Crimson;
            this.HoroscopeBirthdayLabel.Location = new System.Drawing.Point(22, 11);
            this.HoroscopeBirthdayLabel.Name = "HoroscopeBirthdayLabel";
            this.HoroscopeBirthdayLabel.Size = new System.Drawing.Size(113, 30);
            this.HoroscopeBirthdayLabel.TabIndex = 7;
            this.HoroscopeBirthdayLabel.Text = "Birthday: ...";
            // 
            // PlaylistTabPage
            // 
            this.PlaylistTabPage.BackColor = System.Drawing.Color.White;
            this.PlaylistTabPage.Controls.Add(this.GetPlaylistButton);
            this.PlaylistTabPage.Controls.Add(this.pictureBox6);
            this.PlaylistTabPage.Controls.Add(this.Notes1PictureBox);
            this.PlaylistTabPage.Location = new System.Drawing.Point(4, 35);
            this.PlaylistTabPage.Name = "PlaylistTabPage";
            this.PlaylistTabPage.Size = new System.Drawing.Size(970, 246);
            this.PlaylistTabPage.TabIndex = 8;
            this.PlaylistTabPage.Text = "Playlist";
            // 
            // GetPlaylistButton
            // 
            this.GetPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.GetPlaylistButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPlaylistButton.ForeColor = System.Drawing.Color.Thistle;
            this.GetPlaylistButton.Location = new System.Drawing.Point(354, 148);
            this.GetPlaylistButton.Name = "GetPlaylistButton";
            this.GetPlaylistButton.Size = new System.Drawing.Size(229, 54);
            this.GetPlaylistButton.TabIndex = 0;
            this.GetPlaylistButton.Text = "Get Playlist!";
            this.GetPlaylistButton.UseVisualStyleBackColor = false;
            this.GetPlaylistButton.Click += new System.EventHandler(this.getPlaylistButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MyFacebookApp.Properties.Resources.music2;
            this.pictureBox6.Location = new System.Drawing.Point(572, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(386, 200);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // Notes1PictureBox
            // 
            this.Notes1PictureBox.Image = global::MyFacebookApp.Properties.Resources.music1;
            this.Notes1PictureBox.Location = new System.Drawing.Point(0, 36);
            this.Notes1PictureBox.Name = "Notes1PictureBox";
            this.Notes1PictureBox.Size = new System.Drawing.Size(356, 187);
            this.Notes1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Notes1PictureBox.TabIndex = 1;
            this.Notes1PictureBox.TabStop = false;
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.BackColor = System.Drawing.Color.Snow;
            this.AlbumsTab.Controls.Add(this.AlbumsPanel);
            this.AlbumsTab.Controls.Add(this.CreateAlbumButton);
            this.AlbumsTab.Controls.Add(this.FetchAlbumsButton);
            this.AlbumsTab.Controls.Add(this.AlbumsOrderCheckBox);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlbumsTab.Location = new System.Drawing.Point(4, 35);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Size = new System.Drawing.Size(970, 246);
            this.AlbumsTab.TabIndex = 5;
            this.AlbumsTab.Text = "Albums";
            // 
            // AlbumsPanel
            // 
            this.AlbumsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.AlbumsPanel.Controls.Add(createdTimeLabel);
            this.AlbumsPanel.Controls.Add(this.createdTimeDateTimePicker);
            this.AlbumsPanel.Controls.Add(descriptionLabel);
            this.AlbumsPanel.Controls.Add(this.descriptionTextBox1);
            this.AlbumsPanel.Controls.Add(imageAlbumLabel);
            this.AlbumsPanel.Controls.Add(this.imageAlbumPictureBox);
            this.AlbumsPanel.Controls.Add(this.label5);
            this.AlbumsPanel.Controls.Add(this.pictureBox5);
            this.AlbumsPanel.Location = new System.Drawing.Point(8, 16);
            this.AlbumsPanel.Name = "AlbumsPanel";
            this.AlbumsPanel.Size = new System.Drawing.Size(371, 214);
            this.AlbumsPanel.TabIndex = 28;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.AlbumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9F);
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(121, 82);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(230, 23);
            this.createdTimeDateTimePicker.TabIndex = 28;
            // 
            // AlbumBindingSource
            // 
            this.AlbumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AlbumBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(9, 138);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.ReadOnly = true;
            this.descriptionTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox1.Size = new System.Drawing.Size(342, 62);
            this.descriptionTextBox1.TabIndex = 30;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.BackColor = System.Drawing.Color.White;
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.AlbumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(14, 6);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(90, 69);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 32;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 48);
            this.label5.TabIndex = 26;
            this.label5.Text = "Press on album name from list to see details";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox5.Location = new System.Drawing.Point(226, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // CreateAlbumButton
            // 
            this.CreateAlbumButton.Location = new System.Drawing.Point(867, 94);
            this.CreateAlbumButton.Name = "CreateAlbumButton";
            this.CreateAlbumButton.Size = new System.Drawing.Size(96, 68);
            this.CreateAlbumButton.TabIndex = 9;
            this.CreateAlbumButton.Text = "Create New Album";
            this.CreateAlbumButton.UseVisualStyleBackColor = true;
            this.CreateAlbumButton.Click += new System.EventHandler(this.createAlbumButton_Click);
            // 
            // FetchAlbumsButton
            // 
            this.FetchAlbumsButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchAlbumsButton.Location = new System.Drawing.Point(867, 53);
            this.FetchAlbumsButton.Name = "FetchAlbumsButton";
            this.FetchAlbumsButton.Size = new System.Drawing.Size(96, 35);
            this.FetchAlbumsButton.TabIndex = 8;
            this.FetchAlbumsButton.Text = "Fetch";
            this.FetchAlbumsButton.UseVisualStyleBackColor = true;
            this.FetchAlbumsButton.Click += new System.EventHandler(this.fetchAlbumsButton_Click);
            // 
            // AlbumsOrderCheckBox
            // 
            this.AlbumsOrderCheckBox.AutoSize = true;
            this.AlbumsOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsOrderCheckBox.Location = new System.Drawing.Point(864, 17);
            this.AlbumsOrderCheckBox.Name = "AlbumsOrderCheckBox";
            this.AlbumsOrderCheckBox.Size = new System.Drawing.Size(94, 30);
            this.AlbumsOrderCheckBox.TabIndex = 7;
            this.AlbumsOrderCheckBox.Text = "In order";
            this.AlbumsOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.DataSource = this.AlbumBindingSource;
            this.AlbumsListBox.DisplayMember = "Name";
            this.AlbumsListBox.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 21;
            this.AlbumsListBox.Location = new System.Drawing.Point(385, 16);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(473, 214);
            this.AlbumsListBox.TabIndex = 6;
            // 
            // PostsTab
            // 
            this.PostsTab.BackColor = System.Drawing.Color.Snow;
            this.PostsTab.Controls.Add(this.FetchPostsButton);
            this.PostsTab.Controls.Add(this.PostsListBox);
            this.PostsTab.Location = new System.Drawing.Point(4, 35);
            this.PostsTab.Name = "PostsTab";
            this.PostsTab.Size = new System.Drawing.Size(970, 246);
            this.PostsTab.TabIndex = 2;
            this.PostsTab.Text = "Posts";
            // 
            // FetchPostsButton
            // 
            this.FetchPostsButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.FetchPostsButton.Location = new System.Drawing.Point(15, 12);
            this.FetchPostsButton.Name = "FetchPostsButton";
            this.FetchPostsButton.Size = new System.Drawing.Size(75, 37);
            this.FetchPostsButton.TabIndex = 7;
            this.FetchPostsButton.Text = "Fetch";
            this.FetchPostsButton.UseVisualStyleBackColor = true;
            this.FetchPostsButton.Click += new System.EventHandler(this.fetchPostsButton_Click);
            // 
            // PostsListBox
            // 
            this.PostsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.PostsListBox.ForeColor = System.Drawing.Color.Purple;
            this.PostsListBox.FormattingEnabled = true;
            this.PostsListBox.ItemHeight = 23;
            this.PostsListBox.Location = new System.Drawing.Point(102, 12);
            this.PostsListBox.Name = "PostsListBox";
            this.PostsListBox.Size = new System.Drawing.Size(844, 211);
            this.PostsListBox.TabIndex = 6;
            // 
            // FriendListTab
            // 
            this.FriendListTab.BackColor = System.Drawing.Color.Snow;
            this.FriendListTab.Controls.Add(this.label3);
            this.FriendListTab.Controls.Add(this.FriendsLastNameOrderCheckBox);
            this.FriendListTab.Controls.Add(this.FetchFriendButton);
            this.FriendListTab.Controls.Add(this.FriendsFirstNameOrderCheckBox);
            this.FriendListTab.Controls.Add(this.pictureBox3);
            this.FriendListTab.Controls.Add(this.FriendCheckedPictureBox);
            this.FriendListTab.Controls.Add(this.FriendsListBox);
            this.FriendListTab.Location = new System.Drawing.Point(4, 35);
            this.FriendListTab.Name = "FriendListTab";
            this.FriendListTab.Padding = new System.Windows.Forms.Padding(3);
            this.FriendListTab.Size = new System.Drawing.Size(970, 246);
            this.FriendListTab.TabIndex = 1;
            this.FriendListTab.Text = "Friend List";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label3.Location = new System.Drawing.Point(19, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Press on friend from list to see picture";
            // 
            // FriendsLastNameOrderCheckBox
            // 
            this.FriendsLastNameOrderCheckBox.AutoSize = true;
            this.FriendsLastNameOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsLastNameOrderCheckBox.Location = new System.Drawing.Point(7, 43);
            this.FriendsLastNameOrderCheckBox.Name = "FriendsLastNameOrderCheckBox";
            this.FriendsLastNameOrderCheckBox.Size = new System.Drawing.Size(181, 30);
            this.FriendsLastNameOrderCheckBox.TabIndex = 6;
            this.FriendsLastNameOrderCheckBox.Text = "Order by last name";
            this.FriendsLastNameOrderCheckBox.UseVisualStyleBackColor = true;
            this.FriendsLastNameOrderCheckBox.CheckedChanged += new System.EventHandler(this.friendsLastNameOrderCheckBox_CheckedChanged);
            // 
            // FetchFriendButton
            // 
            this.FetchFriendButton.Location = new System.Drawing.Point(102, 79);
            this.FetchFriendButton.Name = "FetchFriendButton";
            this.FetchFriendButton.Size = new System.Drawing.Size(85, 34);
            this.FetchFriendButton.TabIndex = 5;
            this.FetchFriendButton.Text = "Fetch";
            this.FetchFriendButton.UseVisualStyleBackColor = true;
            this.FetchFriendButton.Click += new System.EventHandler(this.fetchFriendButton_Click);
            // 
            // FriendsFirstNameOrderCheckBox
            // 
            this.FriendsFirstNameOrderCheckBox.AutoSize = true;
            this.FriendsFirstNameOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsFirstNameOrderCheckBox.Location = new System.Drawing.Point(7, 15);
            this.FriendsFirstNameOrderCheckBox.Name = "FriendsFirstNameOrderCheckBox";
            this.FriendsFirstNameOrderCheckBox.Size = new System.Drawing.Size(186, 30);
            this.FriendsFirstNameOrderCheckBox.TabIndex = 4;
            this.FriendsFirstNameOrderCheckBox.Text = "Order by first name";
            this.FriendsFirstNameOrderCheckBox.UseVisualStyleBackColor = true;
            this.FriendsFirstNameOrderCheckBox.CheckedChanged += new System.EventHandler(this.friendsFirstNameOrderCheckBox_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox3.Location = new System.Drawing.Point(3, 279);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // FriendCheckedPictureBox
            // 
            this.FriendCheckedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FriendCheckedPictureBox.Image = global::MyFacebookApp.Properties.Resources.friend;
            this.FriendCheckedPictureBox.Location = new System.Drawing.Point(857, 19);
            this.FriendCheckedPictureBox.Name = "FriendCheckedPictureBox";
            this.FriendCheckedPictureBox.Size = new System.Drawing.Size(89, 104);
            this.FriendCheckedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FriendCheckedPictureBox.TabIndex = 10;
            this.FriendCheckedPictureBox.TabStop = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 23;
            this.FriendsListBox.Location = new System.Drawing.Point(198, 19);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(653, 211);
            this.FriendsListBox.TabIndex = 3;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // LikedPagesTab
            // 
            this.LikedPagesTab.BackColor = System.Drawing.Color.Snow;
            this.LikedPagesTab.Controls.Add(this.label4);
            this.LikedPagesTab.Controls.Add(this.FetchLikedPagesButton);
            this.LikedPagesTab.Controls.Add(this.LikedPagesInOrderCheckBox);
            this.LikedPagesTab.Controls.Add(this.pictureBox4);
            this.LikedPagesTab.Controls.Add(this.LikedPagePictureBox);
            this.LikedPagesTab.Controls.Add(this.LikedPagesListBox);
            this.LikedPagesTab.Location = new System.Drawing.Point(4, 35);
            this.LikedPagesTab.Name = "LikedPagesTab";
            this.LikedPagesTab.Size = new System.Drawing.Size(970, 246);
            this.LikedPagesTab.TabIndex = 4;
            this.LikedPagesTab.Text = "Liked Pages";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.5F);
            this.label4.Location = new System.Drawing.Point(849, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 52);
            this.label4.TabIndex = 29;
            this.label4.Text = "Press on page from list to see picture";
            // 
            // FetchLikedPagesButton
            // 
            this.FetchLikedPagesButton.Location = new System.Drawing.Point(35, 56);
            this.FetchLikedPagesButton.Name = "FetchLikedPagesButton";
            this.FetchLikedPagesButton.Size = new System.Drawing.Size(66, 31);
            this.FetchLikedPagesButton.TabIndex = 5;
            this.FetchLikedPagesButton.Text = "Fetch";
            this.FetchLikedPagesButton.UseVisualStyleBackColor = true;
            this.FetchLikedPagesButton.Click += new System.EventHandler(this.fetchLikedPagesButton_Click);
            // 
            // LikedPagesInOrderCheckBox
            // 
            this.LikedPagesInOrderCheckBox.AutoSize = true;
            this.LikedPagesInOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPagesInOrderCheckBox.Location = new System.Drawing.Point(16, 20);
            this.LikedPagesInOrderCheckBox.Name = "LikedPagesInOrderCheckBox";
            this.LikedPagesInOrderCheckBox.Size = new System.Drawing.Size(94, 30);
            this.LikedPagesInOrderCheckBox.TabIndex = 4;
            this.LikedPagesInOrderCheckBox.Text = "In order";
            this.LikedPagesInOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox4.Location = new System.Drawing.Point(829, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // LikedPagePictureBox
            // 
            this.LikedPagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LikedPagePictureBox.Image = global::MyFacebookApp.Properties.Resources.page;
            this.LikedPagePictureBox.Location = new System.Drawing.Point(844, 26);
            this.LikedPagePictureBox.Name = "LikedPagePictureBox";
            this.LikedPagePictureBox.Size = new System.Drawing.Size(79, 93);
            this.LikedPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikedPagePictureBox.TabIndex = 11;
            this.LikedPagePictureBox.TabStop = false;
            // 
            // LikedPagesListBox
            // 
            this.LikedPagesListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.LikedPagesListBox.FormattingEnabled = true;
            this.LikedPagesListBox.ItemHeight = 23;
            this.LikedPagesListBox.Location = new System.Drawing.Point(116, 26);
            this.LikedPagesListBox.Name = "LikedPagesListBox";
            this.LikedPagesListBox.Size = new System.Drawing.Size(705, 211);
            this.LikedPagesListBox.TabIndex = 3;
            this.LikedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.likedPagesListBox_SelectedIndexChanged);
            // 
            // GetInTouchTab
            // 
            this.GetInTouchTab.BackColor = System.Drawing.Color.White;
            this.GetInTouchTab.Controls.Add(this.label2);
            this.GetInTouchTab.Controls.Add(this.pictureBox2);
            this.GetInTouchTab.Controls.Add(this.GetInThouchPictureBox);
            this.GetInTouchTab.Controls.Add(this.Hearts2PictureBox);
            this.GetInTouchTab.Controls.Add(this.HeartsPictureBox);
            this.GetInTouchTab.Controls.Add(this.SingelsFriendsListBox);
            this.GetInTouchTab.Controls.Add(this.FetchSingelsFriendsButton);
            this.GetInTouchTab.Controls.Add(this.GenderComboBox);
            this.GetInTouchTab.Controls.Add(this.GenderLabel);
            this.GetInTouchTab.Location = new System.Drawing.Point(4, 35);
            this.GetInTouchTab.Name = "GetInTouchTab";
            this.GetInTouchTab.Size = new System.Drawing.Size(970, 246);
            this.GetInTouchTab.TabIndex = 7;
            this.GetInTouchTab.Text = "Get In Touch";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label2.Location = new System.Drawing.Point(812, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 62);
            this.label2.TabIndex = 25;
            this.label2.Text = "Press on friend from list to see picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox2.Location = new System.Drawing.Point(794, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // GetInThouchPictureBox
            // 
            this.GetInThouchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GetInThouchPictureBox.Image = global::MyFacebookApp.Properties.Resources.singleFriend;
            this.GetInThouchPictureBox.Location = new System.Drawing.Point(800, 72);
            this.GetInThouchPictureBox.Name = "GetInThouchPictureBox";
            this.GetInThouchPictureBox.Size = new System.Drawing.Size(73, 94);
            this.GetInThouchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GetInThouchPictureBox.TabIndex = 11;
            this.GetInThouchPictureBox.TabStop = false;
            // 
            // Hearts2PictureBox
            // 
            this.Hearts2PictureBox.Image = global::MyFacebookApp.Properties.Resources.hearts;
            this.Hearts2PictureBox.Location = new System.Drawing.Point(47, 6);
            this.Hearts2PictureBox.Name = "Hearts2PictureBox";
            this.Hearts2PictureBox.Size = new System.Drawing.Size(61, 60);
            this.Hearts2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hearts2PictureBox.TabIndex = 9;
            this.Hearts2PictureBox.TabStop = false;
            // 
            // HeartsPictureBox
            // 
            this.HeartsPictureBox.Image = global::MyFacebookApp.Properties.Resources.hearts;
            this.HeartsPictureBox.Location = new System.Drawing.Point(702, 6);
            this.HeartsPictureBox.Name = "HeartsPictureBox";
            this.HeartsPictureBox.Size = new System.Drawing.Size(61, 60);
            this.HeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeartsPictureBox.TabIndex = 8;
            this.HeartsPictureBox.TabStop = false;
            // 
            // SingelsFriendsListBox
            // 
            this.SingelsFriendsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.SingelsFriendsListBox.ForeColor = System.Drawing.Color.Red;
            this.SingelsFriendsListBox.FormattingEnabled = true;
            this.SingelsFriendsListBox.ItemHeight = 23;
            this.SingelsFriendsListBox.Location = new System.Drawing.Point(30, 72);
            this.SingelsFriendsListBox.Name = "SingelsFriendsListBox";
            this.SingelsFriendsListBox.Size = new System.Drawing.Size(754, 165);
            this.SingelsFriendsListBox.TabIndex = 7;
            this.SingelsFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.singelsFriendsListBox_SelectedIndexChanged);
            // 
            // FetchSingelsFriendsButton
            // 
            this.FetchSingelsFriendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FetchSingelsFriendsButton.Font = new System.Drawing.Font("Segoe Print", 12.75F);
            this.FetchSingelsFriendsButton.ForeColor = System.Drawing.Color.DarkRed;
            this.FetchSingelsFriendsButton.Location = new System.Drawing.Point(466, 13);
            this.FetchSingelsFriendsButton.Name = "FetchSingelsFriendsButton";
            this.FetchSingelsFriendsButton.Size = new System.Drawing.Size(222, 40);
            this.FetchSingelsFriendsButton.TabIndex = 2;
            this.FetchSingelsFriendsButton.Text = "Get singels friend list!";
            this.FetchSingelsFriendsButton.UseVisualStyleBackColor = false;
            this.FetchSingelsFriendsButton.Click += new System.EventHandler(this.fetchSingelsFriendsButton_Click);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.AllowDrop = true;
            this.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GenderComboBox.Location = new System.Drawing.Point(341, 18);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 34);
            this.GenderComboBox.TabIndex = 1;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenderLabel.Location = new System.Drawing.Point(112, 23);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(224, 26);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Choose your desired gender:";
            // 
            // UserBirthdayLabel
            // 
            this.UserBirthdayLabel.AutoSize = true;
            this.UserBirthdayLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserBirthdayLabel.ForeColor = System.Drawing.Color.Black;
            this.UserBirthdayLabel.Location = new System.Drawing.Point(106, 257);
            this.UserBirthdayLabel.Name = "UserBirthdayLabel";
            this.UserBirthdayLabel.Size = new System.Drawing.Size(22, 19);
            this.UserBirthdayLabel.TabIndex = 4;
            this.UserBirthdayLabel.Text = " ...";
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.UserEmailLabel.Location = new System.Drawing.Point(110, 341);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(18, 19);
            this.UserEmailLabel.TabIndex = 5;
            this.UserEmailLabel.Text = "...";
            // 
            // UserLivesInLabel
            // 
            this.UserLivesInLabel.AutoSize = true;
            this.UserLivesInLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserLivesInLabel.ForeColor = System.Drawing.Color.Black;
            this.UserLivesInLabel.Location = new System.Drawing.Point(110, 277);
            this.UserLivesInLabel.Name = "UserLivesInLabel";
            this.UserLivesInLabel.Size = new System.Drawing.Size(18, 19);
            this.UserLivesInLabel.TabIndex = 6;
            this.UserLivesInLabel.Text = "...";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.StatusLabel.Location = new System.Drawing.Point(355, 237);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(157, 23);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "What\'s on your mind?";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StatusTextBox.Location = new System.Drawing.Point(359, 259);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(292, 27);
            this.StatusTextBox.TabIndex = 8;
            // 
            // PostStatusButton
            // 
            this.PostStatusButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PostStatusButton.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.PostStatusButton.Location = new System.Drawing.Point(577, 292);
            this.PostStatusButton.Name = "PostStatusButton";
            this.PostStatusButton.Size = new System.Drawing.Size(74, 27);
            this.PostStatusButton.TabIndex = 9;
            this.PostStatusButton.Text = "Post";
            this.PostStatusButton.UseVisualStyleBackColor = false;
            this.PostStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // UserInterestedInLabel
            // 
            this.UserInterestedInLabel.AutoSize = true;
            this.UserInterestedInLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserInterestedInLabel.ForeColor = System.Drawing.Color.Black;
            this.UserInterestedInLabel.Location = new System.Drawing.Point(110, 298);
            this.UserInterestedInLabel.Name = "UserInterestedInLabel";
            this.UserInterestedInLabel.Size = new System.Drawing.Size(18, 19);
            this.UserInterestedInLabel.TabIndex = 11;
            this.UserInterestedInLabel.Text = "...";
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.AutoSize = true;
            this.UserGenderLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserGenderLabel.ForeColor = System.Drawing.Color.Black;
            this.UserGenderLabel.Location = new System.Drawing.Point(110, 319);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.Size = new System.Drawing.Size(18, 19);
            this.UserGenderLabel.TabIndex = 12;
            this.UserGenderLabel.Text = "...";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeLabel.Location = new System.Drawing.Point(792, 201);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 15);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Time:";
            // 
            // UiDateHLabel
            // 
            this.UiDateHLabel.AutoSize = true;
            this.UiDateHLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UiDateHLabel.Location = new System.Drawing.Point(792, 218);
            this.UiDateHLabel.Name = "UiDateHLabel";
            this.UiDateHLabel.Size = new System.Drawing.Size(34, 15);
            this.UiDateHLabel.TabIndex = 14;
            this.UiDateHLabel.Text = "Date:";
            // 
            // TimeUILabel
            // 
            this.TimeUILabel.AutoSize = true;
            this.TimeUILabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeUILabel.Location = new System.Drawing.Point(826, 201);
            this.TimeUILabel.Name = "TimeUILabel";
            this.TimeUILabel.Size = new System.Drawing.Size(16, 15);
            this.TimeUILabel.TabIndex = 15;
            this.TimeUILabel.Text = "...";
            // 
            // DateUiLabel
            // 
            this.DateUiLabel.AutoSize = true;
            this.DateUiLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateUiLabel.Location = new System.Drawing.Point(826, 218);
            this.DateUiLabel.Name = "DateUiLabel";
            this.DateUiLabel.Size = new System.Drawing.Size(16, 15);
            this.DateUiLabel.TabIndex = 16;
            this.DateUiLabel.Text = "...";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Interested in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lives In: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // HBIrthdayLlabel
            // 
            this.HBIrthdayLlabel.AutoSize = true;
            this.HBIrthdayLlabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HBIrthdayLlabel.Location = new System.Drawing.Point(19, 257);
            this.HBIrthdayLlabel.Name = "HBIrthdayLlabel";
            this.HBIrthdayLlabel.Size = new System.Drawing.Size(67, 21);
            this.HBIrthdayLlabel.TabIndex = 17;
            this.HBIrthdayLlabel.Text = "Birthday:";
            // 
            // UserProfilePictureBox
            // 
            this.UserProfilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserProfilePictureBox.Location = new System.Drawing.Point(17, 128);
            this.UserProfilePictureBox.Name = "UserProfilePictureBox";
            this.UserProfilePictureBox.Size = new System.Drawing.Size(115, 115);
            this.UserProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserProfilePictureBox.TabIndex = 0;
            this.UserProfilePictureBox.TabStop = false;
            // 
            // CoverPictureBox
            // 
            this.CoverPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CoverPictureBox.Location = new System.Drawing.Point(2, -1);
            this.CoverPictureBox.Name = "CoverPictureBox";
            this.CoverPictureBox.Size = new System.Drawing.Size(977, 199);
            this.CoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverPictureBox.TabIndex = 10;
            this.CoverPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(979, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HBIrthdayLlabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.DateUiLabel);
            this.Controls.Add(this.TimeUILabel);
            this.Controls.Add(this.UiDateHLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.UserGenderLabel);
            this.Controls.Add(this.UserInterestedInLabel);
            this.Controls.Add(this.UserLivesInLabel);
            this.Controls.Add(this.UserEmailLabel);
            this.Controls.Add(this.UserBirthdayLabel);
            this.Controls.Add(this.UserProfilePictureBox);
            this.Controls.Add(this.PostStatusButton);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.CoverPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "My Facebook Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.UserTabControl.ResumeLayout(false);
            this.EventsTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EventsGroupBox.ResumeLayout(false);
            this.EventsGroupBox.PerformLayout();
            this.CheckInsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.HoroscopeTab.ResumeLayout(false);
            this.HoroscopeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignPictureBox)).EndInit();
            this.PlaylistTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes1PictureBox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            this.AlbumsPanel.ResumeLayout(false);
            this.AlbumsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.PostsTab.ResumeLayout(false);
            this.FriendListTab.ResumeLayout(false);
            this.FriendListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendCheckedPictureBox)).EndInit();
            this.LikedPagesTab.ResumeLayout(false);
            this.LikedPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).EndInit();
            this.GetInTouchTab.ResumeLayout(false);
            this.GetInTouchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInThouchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserProfilePictureBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.TabPage FriendListTab;
        private System.Windows.Forms.TabPage PostsTab;
        private System.Windows.Forms.TabPage CheckInsTab;
        private System.Windows.Forms.TabPage LikedPagesTab;
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.TabPage HoroscopeTab;
        private System.Windows.Forms.TabPage GetInTouchTab;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Label UserBirthdayLabel;
        private System.Windows.Forms.Label UserEmailLabel;
        private System.Windows.Forms.Label UserLivesInLabel;
        private System.Windows.Forms.CheckBox FriendsLastNameOrderCheckBox;
        private System.Windows.Forms.Button FetchFriendButton;
        private System.Windows.Forms.CheckBox FriendsFirstNameOrderCheckBox;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Button FetchPostsButton;
        private System.Windows.Forms.ListBox PostsListBox;
        private System.Windows.Forms.Button FetchLikedPagesButton;
        private System.Windows.Forms.CheckBox LikedPagesInOrderCheckBox;
        private System.Windows.Forms.ListBox LikedPagesListBox;
        private System.Windows.Forms.Button FetchAlbumsButton;
        private System.Windows.Forms.CheckBox AlbumsOrderCheckBox;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label ZodiacSignLabel;
        private System.Windows.Forms.TextBox HoroscopeTextBox;
        private System.Windows.Forms.Label HoroscopeBirthdayLabel;
        private System.Windows.Forms.ListBox SingelsFriendsListBox;
        private System.Windows.Forms.Button FetchSingelsFriendsButton;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button PostStatusButton;
        private System.Windows.Forms.PictureBox FriendCheckedPictureBox;
        private System.Windows.Forms.Button FetchHoroscopeButton;
        private System.Windows.Forms.PictureBox HeartsPictureBox;
        private System.Windows.Forms.PictureBox Hearts2PictureBox;
        private System.Windows.Forms.Button CreateAlbumButton;
        private System.Windows.Forms.Button ShowCheckInsButton;
        private System.Windows.Forms.TabPage PlaylistTabPage;
        private System.Windows.Forms.PictureBox Notes1PictureBox;
        private System.Windows.Forms.Button GetPlaylistButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox LikedPagePictureBox;
        private System.Windows.Forms.PictureBox GetInThouchPictureBox;
        private System.Windows.Forms.PictureBox SignPictureBox;
        private System.Windows.Forms.Button SelectsPartnerButton;
        private System.Windows.Forms.Button GetMathcesButton;
        private System.Windows.Forms.GroupBox EventsGroupBox;
        private System.Windows.Forms.RadioButton NotRepliedRadioButton;
        private System.Windows.Forms.RadioButton AttendingRadioButton;
        private System.Windows.Forms.RadioButton MaybeRadioButton;
        private System.Windows.Forms.RadioButton NotAttendingRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox CoverPictureBox;
        private System.Windows.Forms.Label UserInterestedInLabel;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label UiDateHLabel;
        private System.Windows.Forms.Label TimeUILabel;
        private System.Windows.Forms.Label DateUiLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label HBIrthdayLlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource EventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.Panel AlbumsPanel;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource AlbumBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}