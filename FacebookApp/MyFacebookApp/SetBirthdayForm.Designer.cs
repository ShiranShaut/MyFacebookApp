namespace MyFacebookApp
{
    public partial class SetBirthdayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetBirthdayForm));
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SetBirthdayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(27, 9);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthdayDateTimePicker.TabIndex = 0;
            // 
            // SetBirthdayButton
            // 
            this.SetBirthdayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SetBirthdayButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBirthdayButton.Location = new System.Drawing.Point(88, 35);
            this.SetBirthdayButton.Name = "SetBirthdayButton";
            this.SetBirthdayButton.Size = new System.Drawing.Size(75, 31);
            this.SetBirthdayButton.TabIndex = 1;
            this.SetBirthdayButton.Text = "Set";
            this.SetBirthdayButton.UseVisualStyleBackColor = false;
            this.SetBirthdayButton.Click += new System.EventHandler(this.setBirthdayButton_Click);
            // 
            // SetBirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 70);
            this.Controls.Add(this.SetBirthdayButton);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetBirthdayForm";
            this.Text = "Set Birthday Date";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setBirthdayForm_FormClosing);
            this.Load += new System.EventHandler(this.setBirthdayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Button SetBirthdayButton;
    }
}