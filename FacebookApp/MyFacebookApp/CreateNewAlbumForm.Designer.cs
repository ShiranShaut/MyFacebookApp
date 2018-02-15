namespace MyFacebookApp
{
    public partial class CreateNewAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewAlbumForm));
            this.AlbumNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PrivacyLabel = new System.Windows.Forms.Label();
            this.CreateAlbumButton = new System.Windows.Forms.Button();
            this.AlbumNameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PrivacyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AlbumNameLabel
            // 
            this.AlbumNameLabel.AutoSize = true;
            this.AlbumNameLabel.ForeColor = System.Drawing.Color.Salmon;
            this.AlbumNameLabel.Location = new System.Drawing.Point(11, 14);
            this.AlbumNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumNameLabel.Name = "AlbumNameLabel";
            this.AlbumNameLabel.Size = new System.Drawing.Size(101, 23);
            this.AlbumNameLabel.TabIndex = 0;
            this.AlbumNameLabel.Text = "Album Name:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Salmon;
            this.DescriptionLabel.Location = new System.Drawing.Point(11, 58);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 23);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description:";
            // 
            // PrivacyLabel
            // 
            this.PrivacyLabel.AutoSize = true;
            this.PrivacyLabel.ForeColor = System.Drawing.Color.Salmon;
            this.PrivacyLabel.Location = new System.Drawing.Point(11, 103);
            this.PrivacyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrivacyLabel.Name = "PrivacyLabel";
            this.PrivacyLabel.Size = new System.Drawing.Size(64, 23);
            this.PrivacyLabel.TabIndex = 2;
            this.PrivacyLabel.Text = "Privacy:";
            // 
            // CreateAlbumButton
            // 
            this.CreateAlbumButton.BackColor = System.Drawing.Color.MistyRose;
            this.CreateAlbumButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAlbumButton.ForeColor = System.Drawing.Color.Salmon;
            this.CreateAlbumButton.Location = new System.Drawing.Point(317, 143);
            this.CreateAlbumButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateAlbumButton.Name = "CreateAlbumButton";
            this.CreateAlbumButton.Size = new System.Drawing.Size(172, 53);
            this.CreateAlbumButton.TabIndex = 3;
            this.CreateAlbumButton.Text = "Create Album!";
            this.CreateAlbumButton.UseVisualStyleBackColor = false;
            this.CreateAlbumButton.Click += new System.EventHandler(this.createAlbumButton_Click);
            // 
            // AlbumNameTextBox
            // 
            this.AlbumNameTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.AlbumNameTextBox.Location = new System.Drawing.Point(114, 14);
            this.AlbumNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumNameTextBox.Name = "AlbumNameTextBox";
            this.AlbumNameTextBox.Size = new System.Drawing.Size(375, 30);
            this.AlbumNameTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.DescriptionTextBox.Location = new System.Drawing.Point(114, 58);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(375, 30);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // PrivacyTextBox
            // 
            this.PrivacyTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.PrivacyTextBox.Location = new System.Drawing.Point(114, 103);
            this.PrivacyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrivacyTextBox.Name = "PrivacyTextBox";
            this.PrivacyTextBox.Size = new System.Drawing.Size(375, 30);
            this.PrivacyTextBox.TabIndex = 6;
            // 
            // CreateNewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 212);
            this.Controls.Add(this.PrivacyTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.AlbumNameTextBox);
            this.Controls.Add(this.CreateAlbumButton);
            this.Controls.Add(this.PrivacyLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AlbumNameLabel);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateNewAlbumForm";
            this.Text = "Create New Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createNewAlbumForm_FormClosing);
            this.Load += new System.EventHandler(this.createNewAlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlbumNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PrivacyLabel;
        private System.Windows.Forms.Button CreateAlbumButton;
        private System.Windows.Forms.TextBox AlbumNameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox PrivacyTextBox;
    }
}