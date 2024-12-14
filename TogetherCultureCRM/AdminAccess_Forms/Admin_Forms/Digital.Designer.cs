namespace TogetherCultureCRM.AdminAccess_Forms.Admin_Forms
{
    partial class Digital
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelNested = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AccessTypeCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DurationTb = new System.Windows.Forms.TextBox();
            this.UploadDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentTypeTb = new System.Windows.Forms.Label();
            this.ContentType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleTb = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Contentdgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ContentLocationTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripTb = new System.Windows.Forms.TextBox();
            this.panelNested.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contentdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(709, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(151, 29);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Contents List";
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNested.Controls.Add(this.label10);
            this.panelNested.Controls.Add(this.PriceTb);
            this.panelNested.Controls.Add(this.StatusLbl);
            this.panelNested.Controls.Add(this.StatusCb);
            this.panelNested.Controls.Add(this.label8);
            this.panelNested.Controls.Add(this.AccessTypeCb);
            this.panelNested.Controls.Add(this.label7);
            this.panelNested.Controls.Add(this.DurationTb);
            this.panelNested.Controls.Add(this.UploadDate);
            this.panelNested.Controls.Add(this.label1);
            this.panelNested.Controls.Add(this.ContentTypeTb);
            this.panelNested.Controls.Add(this.ContentType);
            this.panelNested.Controls.Add(this.label6);
            this.panelNested.Controls.Add(this.label5);
            this.panelNested.Controls.Add(this.TitleTb);
            this.panelNested.Controls.Add(this.Deletebtn);
            this.panelNested.Controls.Add(this.Editbtn);
            this.panelNested.Controls.Add(this.Addbtn);
            this.panelNested.Controls.Add(this.panel1);
            this.panelNested.Controls.Add(this.Contentdgv);
            this.panelNested.Controls.Add(this.label3);
            this.panelNested.Controls.Add(this.ContentLocationTb);
            this.panelNested.Controls.Add(this.label2);
            this.panelNested.Controls.Add(this.DescripTb);
            this.panelNested.Controls.Add(this.lblWelcome);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1235, 745);
            this.panelNested.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(8, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(4, 544);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(351, 26);
            this.PriceTb.TabIndex = 53;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StatusLbl.Location = new System.Drawing.Point(3, 579);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(68, 25);
            this.StatusLbl.TabIndex = 52;
            this.StatusLbl.Text = "Status";
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.StatusCb.Location = new System.Drawing.Point(3, 607);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(350, 28);
            this.StatusCb.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(3, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Access Type";
            // 
            // AccessTypeCb
            // 
            this.AccessTypeCb.FormattingEnabled = true;
            this.AccessTypeCb.Items.AddRange(new object[] {
            "Free Access",
            "Ticket Access"});
            this.AccessTypeCb.Location = new System.Drawing.Point(3, 485);
            this.AccessTypeCb.Name = "AccessTypeCb";
            this.AccessTypeCb.Size = new System.Drawing.Size(350, 28);
            this.AccessTypeCb.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(3, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Duration";
            // 
            // DurationTb
            // 
            this.DurationTb.Location = new System.Drawing.Point(4, 420);
            this.DurationTb.Name = "DurationTb";
            this.DurationTb.Size = new System.Drawing.Size(351, 26);
            this.DurationTb.TabIndex = 47;
            // 
            // UploadDate
            // 
            this.UploadDate.Location = new System.Drawing.Point(3, 228);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(351, 26);
            this.UploadDate.TabIndex = 46;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "+Add Contents ";
            // 
            // ContentTypeTb
            // 
            this.ContentTypeTb.AutoSize = true;
            this.ContentTypeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContentTypeTb.Location = new System.Drawing.Point(3, 269);
            this.ContentTypeTb.Name = "ContentTypeTb";
            this.ContentTypeTb.Size = new System.Drawing.Size(131, 25);
            this.ContentTypeTb.TabIndex = 44;
            this.ContentTypeTb.Text = "Content Type";
            // 
            // ContentType
            // 
            this.ContentType.Location = new System.Drawing.Point(3, 297);
            this.ContentType.Name = "ContentType";
            this.ContentType.Size = new System.Drawing.Size(351, 26);
            this.ContentType.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(3, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Upload Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Title";
            // 
            // TitleTb
            // 
            this.TitleTb.Location = new System.Drawing.Point(3, 111);
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.Size = new System.Drawing.Size(351, 26);
            this.TitleTb.TabIndex = 39;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Location = new System.Drawing.Point(236, 670);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(89, 37);
            this.Deletebtn.TabIndex = 38;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Location = new System.Drawing.Point(115, 670);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(89, 37);
            this.Editbtn.TabIndex = 37;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Location = new System.Drawing.Point(5, 670);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(89, 37);
            this.Addbtn.TabIndex = 36;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 55);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contents Management";
            // 
            // Contentdgv
            // 
            this.Contentdgv.BackgroundColor = System.Drawing.Color.White;
            this.Contentdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contentdgv.Location = new System.Drawing.Point(378, 91);
            this.Contentdgv.Name = "Contentdgv";
            this.Contentdgv.RowHeadersWidth = 62;
            this.Contentdgv.RowTemplate.Height = 28;
            this.Contentdgv.Size = new System.Drawing.Size(876, 625);
            this.Contentdgv.TabIndex = 31;
            this.Contentdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contentdgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(3, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Location";
            // 
            // ContentLocationTb
            // 
            this.ContentLocationTb.Location = new System.Drawing.Point(3, 362);
            this.ContentLocationTb.Name = "ContentLocationTb";
            this.ContentLocationTb.Size = new System.Drawing.Size(351, 26);
            this.ContentLocationTb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // DescripTb
            // 
            this.DescripTb.Location = new System.Drawing.Point(3, 166);
            this.DescripTb.Name = "DescripTb";
            this.DescripTb.Size = new System.Drawing.Size(351, 26);
            this.DescripTb.TabIndex = 27;
            // 
            // Digital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 745);
            this.Controls.Add(this.panelNested);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Digital";
            this.Text = "Digital";
            this.Load += new System.EventHandler(this.Digital_Load);
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contentdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContentLocationTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripTb;
        private System.Windows.Forms.DataGridView Contentdgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label ContentTypeTb;
        private System.Windows.Forms.TextBox ContentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TitleTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker UploadDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DurationTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AccessTypeCb;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PriceTb;
    }
}