namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    partial class Profile
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
            System.Windows.Forms.Button Editbtn;
            this.panelNested = new System.Windows.Forms.Panel();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.listBoxMemberDetails = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            Editbtn = new System.Windows.Forms.Button();
            this.panelNested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // Editbtn
            // 
            Editbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Editbtn.Location = new System.Drawing.Point(59, 670);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new System.Drawing.Size(136, 49);
            Editbtn.TabIndex = 36;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNested.Controls.Add(this.Uploadbtn);
            this.panelNested.Controls.Add(this.Updatebtn);
            this.panelNested.Controls.Add(Editbtn);
            this.panelNested.Controls.Add(this.listBoxMemberDetails);
            this.panelNested.Controls.Add(this.pictureBoxProfile);
            this.panelNested.Controls.Add(this.lblWelcome);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1235, 745);
            this.panelNested.TabIndex = 3;
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Uploadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uploadbtn.Location = new System.Drawing.Point(556, 670);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(129, 49);
            this.Uploadbtn.TabIndex = 38;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = false;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(301, 670);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(129, 49);
            this.Updatebtn.TabIndex = 37;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            // 
            // listBoxMemberDetails
            // 
            this.listBoxMemberDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxMemberDetails.FormattingEnabled = true;
            this.listBoxMemberDetails.ItemHeight = 25;
            this.listBoxMemberDetails.Location = new System.Drawing.Point(301, 330);
            this.listBoxMemberDetails.Name = "listBoxMemberDetails";
            this.listBoxMemberDetails.Size = new System.Drawing.Size(739, 304);
            this.listBoxMemberDetails.TabIndex = 10;
            this.listBoxMemberDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxMemberDetails_SelectedIndexChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxProfile.Location = new System.Drawing.Point(364, 46);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(355, 212);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 9;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(439, 261);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(164, 29);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Profile Picture";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 745);
            this.Controls.Add(this.panelNested);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox listBoxMemberDetails;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Uploadbtn;
    }
}