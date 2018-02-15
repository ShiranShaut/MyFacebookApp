namespace MyFacebookApp
{
    public partial class CheckInOnMapForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label linkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOnMapForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkInImagePictureBox = new System.Windows.Forms.PictureBox();
            this.checkInWrapperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.CheckInLinkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DesiredCheckInLabel = new System.Windows.Forms.Label();
            this.CheckInsListBox = new System.Windows.Forms.ListBox();
            this.CheckInGMapControl = new GMap.NET.WindowsForms.GMapControl();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInWrapperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            createdTimeLabel.Location = new System.Drawing.Point(8, 158);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(95, 21);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            descriptionLabel.Location = new System.Drawing.Point(8, 191);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(82, 21);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            linkLabel.Location = new System.Drawing.Point(8, 89);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(40, 21);
            linkLabel.TabIndex = 6;
            linkLabel.Text = "Link:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.DesiredCheckInLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CheckInsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CheckInGMapControl);
            this.splitContainer1.Size = new System.Drawing.Size(889, 580);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "! This opertaion take time. please wait...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.checkInImagePictureBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(this.CheckInLinkLinkLabel);
            this.panel1.Location = new System.Drawing.Point(12, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 264);
            this.panel1.TabIndex = 27;
            // 
            // checkInImagePictureBox
            // 
            this.checkInImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.checkInWrapperBindingSource, "CheckInImage", true));
            this.checkInImagePictureBox.Location = new System.Drawing.Point(9, 8);
            this.checkInImagePictureBox.Name = "checkInImagePictureBox";
            this.checkInImagePictureBox.Size = new System.Drawing.Size(81, 70);
            this.checkInImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkInImagePictureBox.TabIndex = 1;
            this.checkInImagePictureBox.TabStop = false;
            // 
            // checkInWrapperBindingSource
            // 
            this.checkInWrapperBindingSource.DataSource = typeof(CheckInsController.CheckInWrapper);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkInWrapperBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(109, 158);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkInWrapperBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(109, 191);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(218, 65);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // CheckInLinkLinkLabel
            // 
            this.CheckInLinkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkInWrapperBindingSource, "Link", true));
            this.CheckInLinkLinkLabel.LinkColor = System.Drawing.Color.Purple;
            this.CheckInLinkLinkLabel.Location = new System.Drawing.Point(111, 89);
            this.CheckInLinkLinkLabel.Name = "CheckInLinkLinkLabel";
            this.CheckInLinkLinkLabel.Size = new System.Drawing.Size(216, 63);
            this.CheckInLinkLinkLabel.TabIndex = 7;
            this.CheckInLinkLinkLabel.TabStop = true;
            this.CheckInLinkLinkLabel.Text = "[Check In Link]";
            this.CheckInLinkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkInLinkLinkLabel_LinkClicked);
            // 
            // DesiredCheckInLabel
            // 
            this.DesiredCheckInLabel.AutoSize = true;
            this.DesiredCheckInLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredCheckInLabel.Location = new System.Drawing.Point(12, 34);
            this.DesiredCheckInLabel.Name = "DesiredCheckInLabel";
            this.DesiredCheckInLabel.Size = new System.Drawing.Size(184, 23);
            this.DesiredCheckInLabel.TabIndex = 1;
            this.DesiredCheckInLabel.Text = "You been on the locations:";
            // 
            // CheckInsListBox
            // 
            this.CheckInsListBox.DataSource = this.checkInWrapperBindingSource;
            this.CheckInsListBox.DisplayMember = "Name";
            this.CheckInsListBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInsListBox.FormattingEnabled = true;
            this.CheckInsListBox.ItemHeight = 23;
            this.CheckInsListBox.Location = new System.Drawing.Point(12, 62);
            this.CheckInsListBox.Name = "CheckInsListBox";
            this.CheckInsListBox.Size = new System.Drawing.Size(338, 234);
            this.CheckInsListBox.TabIndex = 0;
            // 
            // CheckInGMapControl
            // 
            this.CheckInGMapControl.Bearing = 0F;
            this.CheckInGMapControl.CanDragMap = true;
            this.CheckInGMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.CheckInGMapControl.GrayScaleMode = false;
            this.CheckInGMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.CheckInGMapControl.LevelsKeepInMemmory = 5;
            this.CheckInGMapControl.Location = new System.Drawing.Point(3, 0);
            this.CheckInGMapControl.MarkersEnabled = true;
            this.CheckInGMapControl.MaxZoom = 18;
            this.CheckInGMapControl.MinZoom = 0;
            this.CheckInGMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.CheckInGMapControl.Name = "CheckInGMapControl";
            this.CheckInGMapControl.NegativeMode = false;
            this.CheckInGMapControl.PolygonsEnabled = true;
            this.CheckInGMapControl.RetryLoadTile = 0;
            this.CheckInGMapControl.RoutesEnabled = true;
            this.CheckInGMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.CheckInGMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.CheckInGMapControl.ShowTileGridLines = false;
            this.CheckInGMapControl.Size = new System.Drawing.Size(519, 577);
            this.CheckInGMapControl.TabIndex = 0;
            this.CheckInGMapControl.Zoom = 10D;
            // 
            // CheckInOnMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 580);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckInOnMapForm";
            this.Text = "Check Ins On Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.checkInOnMapForm_FormClosing);
            this.Load += new System.EventHandler(this.checkInOnMapForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkInImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInWrapperBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label DesiredCheckInLabel;
        private System.Windows.Forms.ListBox CheckInsListBox;
        private GMap.NET.WindowsForms.GMapControl CheckInGMapControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox checkInImagePictureBox;
        private System.Windows.Forms.BindingSource checkInWrapperBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.LinkLabel CheckInLinkLinkLabel;
        private System.Windows.Forms.Label label1;
    }
}