namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    partial class Members
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpJoinedDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInterests = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.panelNested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNested.Controls.Add(this.cmbMembershipType);
            this.panelNested.Controls.Add(this.dgvMember);
            this.panelNested.Controls.Add(this.View);
            this.panelNested.Controls.Add(this.Delete);
            this.panelNested.Controls.Add(this.Edit);
            this.panelNested.Controls.Add(this.Add);
            this.panelNested.Controls.Add(this.label8);
            this.panelNested.Controls.Add(this.dtpJoinedDate);
            this.panelNested.Controls.Add(this.label7);
            this.panelNested.Controls.Add(this.txtInterests);
            this.panelNested.Controls.Add(this.label6);
            this.panelNested.Controls.Add(this.txtPhone);
            this.panelNested.Controls.Add(this.label4);
            this.panelNested.Controls.Add(this.label3);
            this.panelNested.Controls.Add(this.txtEmail);
            this.panelNested.Controls.Add(this.label2);
            this.panelNested.Controls.Add(this.txtLastName);
            this.panelNested.Controls.Add(this.txtFirstName);
            this.panelNested.Controls.Add(this.label5);
            this.panelNested.Controls.Add(this.panel1);
            this.panelNested.Controls.Add(this.lblWelcome);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1235, 745);
            this.panelNested.TabIndex = 1;
            // 
            // dgvMember
            // 
            this.dgvMember.BackgroundColor = System.Drawing.Color.White;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(378, 95);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.Size = new System.Drawing.Size(876, 625);
            this.dgvMember.TabIndex = 45;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Location = new System.Drawing.Point(131, 670);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(89, 37);
            this.View.TabIndex = 44;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Location = new System.Drawing.Point(252, 610);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 37);
            this.Delete.TabIndex = 43;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(131, 610);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(89, 37);
            this.Edit.TabIndex = 42;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(21, 610);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 37);
            this.Add.TabIndex = 41;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Joined Date ";
            // 
            // dtpJoinedDate
            // 
            this.dtpJoinedDate.Location = new System.Drawing.Point(12, 534);
            this.dtpJoinedDate.Name = "dtpJoinedDate";
            this.dtpJoinedDate.Size = new System.Drawing.Size(351, 26);
            this.dtpJoinedDate.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(18, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Interests";
            // 
            // txtInterests
            // 
            this.txtInterests.Location = new System.Drawing.Point(12, 390);
            this.txtInterests.Name = "txtInterests";
            this.txtInterests.Size = new System.Drawing.Size(351, 26);
            this.txtInterests.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 318);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(351, 26);
            this.txtPhone.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Membership Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 26);
            this.txtEmail.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 182);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(351, 26);
            this.txtLastName.TabIndex = 29;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(12, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(351, 26);
            this.txtFirstName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 47);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Member Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(596, 63);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(158, 29);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Members List";
            // 
            // cmbMembershipType
            // 
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Items.AddRange(new object[] {
            "Community Member",
            "Key Access Member",
            "Creative Workspace Member"});
            this.cmbMembershipType.Location = new System.Drawing.Point(12, 466);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(351, 28);
            this.cmbMembershipType.TabIndex = 46;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 745);
            this.Controls.Add(this.panelNested);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Members";
            this.Text = "Members";
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInterests;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpJoinedDate;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.ComboBox cmbMembershipType;
    }
}