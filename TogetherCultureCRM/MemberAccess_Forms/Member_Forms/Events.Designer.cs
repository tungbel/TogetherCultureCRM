namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    partial class Events
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
            this.lblEventsAvailable = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboBoxSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.chkBoxPast = new System.Windows.Forms.CheckBox();
            this.chkBoxFull = new System.Windows.Forms.CheckBox();
            this.chkBoxUpcoming = new System.Windows.Forms.CheckBox();
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelNested.SuspendLayout();
            this.panelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.Controls.Add(this.panelBG);
            this.panelNested.Controls.Add(this.lblFilter);
            this.panelNested.Controls.Add(this.chkBoxPast);
            this.panelNested.Controls.Add(this.chkBoxFull);
            this.panelNested.Controls.Add(this.chkBoxUpcoming);
            this.panelNested.Controls.Add(this.cboBoxSort);
            this.panelNested.Controls.Add(this.lblSort);
            this.panelNested.Controls.Add(this.lblEventsAvailable);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1098, 596);
            this.panelNested.TabIndex = 2;
            // 
            // lblEventsAvailable
            // 
            this.lblEventsAvailable.AutoSize = true;
            this.lblEventsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsAvailable.Location = new System.Drawing.Point(35, 27);
            this.lblEventsAvailable.Name = "lblEventsAvailable";
            this.lblEventsAvailable.Size = new System.Drawing.Size(157, 25);
            this.lblEventsAvailable.TabIndex = 8;
            this.lblEventsAvailable.Text = "Events Available";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1687, 620);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // cboBoxSort
            // 
            this.cboBoxSort.FormattingEnabled = true;
            this.cboBoxSort.Items.AddRange(new object[] {
            "Date",
            "Capacity",
            "Name"});
            this.cboBoxSort.Location = new System.Drawing.Point(519, 109);
            this.cboBoxSort.Name = "cboBoxSort";
            this.cboBoxSort.Size = new System.Drawing.Size(290, 24);
            this.cboBoxSort.TabIndex = 11;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(514, 80);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(48, 25);
            this.lblSort.TabIndex = 10;
            this.lblSort.Text = "Sort";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(123, 80);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(54, 25);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter";
            // 
            // chkBoxPast
            // 
            this.chkBoxPast.AutoSize = true;
            this.chkBoxPast.Location = new System.Drawing.Point(290, 114);
            this.chkBoxPast.Name = "chkBoxPast";
            this.chkBoxPast.Size = new System.Drawing.Size(91, 20);
            this.chkBoxPast.TabIndex = 13;
            this.chkBoxPast.Text = "Upcoming";
            this.chkBoxPast.UseVisualStyleBackColor = true;
            // 
            // chkBoxFull
            // 
            this.chkBoxFull.AutoSize = true;
            this.chkBoxFull.Location = new System.Drawing.Point(230, 114);
            this.chkBoxFull.Name = "chkBoxFull";
            this.chkBoxFull.Size = new System.Drawing.Size(50, 20);
            this.chkBoxFull.TabIndex = 14;
            this.chkBoxFull.Text = "Full";
            this.chkBoxFull.UseVisualStyleBackColor = true;
            // 
            // chkBoxUpcoming
            // 
            this.chkBoxUpcoming.AutoSize = true;
            this.chkBoxUpcoming.Location = new System.Drawing.Point(128, 113);
            this.chkBoxUpcoming.Name = "chkBoxUpcoming";
            this.chkBoxUpcoming.Size = new System.Drawing.Size(91, 20);
            this.chkBoxUpcoming.TabIndex = 15;
            this.chkBoxUpcoming.Text = "Upcoming";
            this.chkBoxUpcoming.UseVisualStyleBackColor = true;
            // 
            // panelBG
            // 
            this.panelBG.AutoScroll = true;
            this.panelBG.BackColor = System.Drawing.Color.White;
            this.panelBG.Controls.Add(this.flowLayoutPanel1);
            this.panelBG.Location = new System.Drawing.Point(40, 159);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(1783, 690);
            this.panelBG.TabIndex = 16;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 596);
            this.Controls.Add(this.panelNested);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            this.panelBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Label lblEventsAvailable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.CheckBox chkBoxPast;
        private System.Windows.Forms.CheckBox chkBoxFull;
        private System.Windows.Forms.CheckBox chkBoxUpcoming;
        private System.Windows.Forms.ComboBox cboBoxSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Panel panelBG;
    }
}