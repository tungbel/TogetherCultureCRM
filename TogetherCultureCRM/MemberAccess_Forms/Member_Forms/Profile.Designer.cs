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
            this.panelNested = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelNested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.BackColor = System.Drawing.Color.Transparent;
            this.panelNested.Controls.Add(this.button3);
            this.panelNested.Controls.Add(this.button2);
            this.panelNested.Controls.Add(this.Information);
            this.panelNested.Controls.Add(this.pictureBox1);
            this.panelNested.Controls.Add(this.lblWelcome);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1235, 745);
            this.panelNested.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(359, 274);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(83, 29);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(364, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 212);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Information
            // 
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Information.FormattingEnabled = true;
            this.Information.ItemHeight = 25;
            this.Information.Location = new System.Drawing.Point(301, 330);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(543, 304);
            this.Information.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(301, 682);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(107, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
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
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox Information;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}