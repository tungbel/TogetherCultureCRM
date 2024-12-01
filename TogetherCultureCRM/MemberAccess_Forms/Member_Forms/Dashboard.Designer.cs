namespace TogetherCultureCRM.MemberAccess_Forms.Member_Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelNested = new System.Windows.Forms.Panel();
            this.dgvBenefitsAvailable = new System.Windows.Forms.DataGridView();
            this.dgvBenefitsUsed = new System.Windows.Forms.DataGridView();
            this.lstDigitalContent = new System.Windows.Forms.ListBox();
            this.dgvUpcomingEvents = new System.Windows.Forms.DataGridView();
            this.lblDigitalContentsA = new System.Windows.Forms.Label();
            this.lblAllBenefitsAvailable = new System.Windows.Forms.Label();
            this.lblAllBenefitsUsed = new System.Windows.Forms.Label();
            this.lblUpComingEvent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventJoinedCount = new System.Windows.Forms.Label();
            this.lblTotalEvent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBenefitsAvailable = new System.Windows.Forms.Panel();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.labelBenefitsAvailable = new System.Windows.Forms.Label();
            this.panelBenefitsUsed = new System.Windows.Forms.Panel();
            this.lblUsedCount = new System.Windows.Forms.Label();
            this.labelBenefitsUsed = new System.Windows.Forms.Label();
            this.panelNested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefitsAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefitsUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBenefitsAvailable.SuspendLayout();
            this.panelBenefitsUsed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(17, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(152, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, User!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panelNested
            // 
            this.panelNested.AutoScroll = true;
            this.panelNested.AutoSize = true;
            this.panelNested.Controls.Add(this.dgvBenefitsAvailable);
            this.panelNested.Controls.Add(this.dgvBenefitsUsed);
            this.panelNested.Controls.Add(this.lstDigitalContent);
            this.panelNested.Controls.Add(this.dgvUpcomingEvents);
            this.panelNested.Controls.Add(this.lblDigitalContentsA);
            this.panelNested.Controls.Add(this.lblAllBenefitsAvailable);
            this.panelNested.Controls.Add(this.lblAllBenefitsUsed);
            this.panelNested.Controls.Add(this.lblUpComingEvent);
            this.panelNested.Controls.Add(this.panel1);
            this.panelNested.Controls.Add(this.panel2);
            this.panelNested.Controls.Add(this.panelBenefitsAvailable);
            this.panelNested.Controls.Add(this.panelBenefitsUsed);
            this.panelNested.Controls.Add(this.lblWelcome);
            this.panelNested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNested.Location = new System.Drawing.Point(0, 0);
            this.panelNested.Name = "panelNested";
            this.panelNested.Size = new System.Drawing.Size(1098, 596);
            this.panelNested.TabIndex = 0;
            // 
            // dgvBenefitsAvailable
            // 
            this.dgvBenefitsAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenefitsAvailable.BackgroundColor = System.Drawing.Color.White;
            this.dgvBenefitsAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBenefitsAvailable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenefitsAvailable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenefitsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenefitsAvailable.Location = new System.Drawing.Point(957, 413);
            this.dgvBenefitsAvailable.Name = "dgvBenefitsAvailable";
            this.dgvBenefitsAvailable.RowHeadersVisible = false;
            this.dgvBenefitsAvailable.RowHeadersWidth = 51;
            this.dgvBenefitsAvailable.RowTemplate.Height = 24;
            this.dgvBenefitsAvailable.Size = new System.Drawing.Size(795, 292);
            this.dgvBenefitsAvailable.TabIndex = 8;
            // 
            // dgvBenefitsUsed
            // 
            this.dgvBenefitsUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenefitsUsed.BackgroundColor = System.Drawing.Color.White;
            this.dgvBenefitsUsed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBenefitsUsed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenefitsUsed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenefitsUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenefitsUsed.GridColor = System.Drawing.Color.White;
            this.dgvBenefitsUsed.Location = new System.Drawing.Point(122, 413);
            this.dgvBenefitsUsed.Name = "dgvBenefitsUsed";
            this.dgvBenefitsUsed.RowHeadersVisible = false;
            this.dgvBenefitsUsed.RowHeadersWidth = 51;
            this.dgvBenefitsUsed.RowTemplate.Height = 24;
            this.dgvBenefitsUsed.Size = new System.Drawing.Size(795, 292);
            this.dgvBenefitsUsed.TabIndex = 8;
            // 
            // lstDigitalContent
            // 
            this.lstDigitalContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDigitalContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDigitalContent.FormattingEnabled = true;
            this.lstDigitalContent.ItemHeight = 20;
            this.lstDigitalContent.Location = new System.Drawing.Point(122, 1255);
            this.lstDigitalContent.Margin = new System.Windows.Forms.Padding(8);
            this.lstDigitalContent.MultiColumn = true;
            this.lstDigitalContent.Name = "lstDigitalContent";
            this.lstDigitalContent.Size = new System.Drawing.Size(1630, 320);
            this.lstDigitalContent.TabIndex = 6;
            // 
            // dgvUpcomingEvents
            // 
            this.dgvUpcomingEvents.AllowUserToAddRows = false;
            this.dgvUpcomingEvents.AllowUserToDeleteRows = false;
            this.dgvUpcomingEvents.AllowUserToOrderColumns = true;
            this.dgvUpcomingEvents.AllowUserToResizeColumns = false;
            this.dgvUpcomingEvents.AllowUserToResizeRows = false;
            this.dgvUpcomingEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpcomingEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUpcomingEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpcomingEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUpcomingEvents.ColumnHeadersHeight = 35;
            this.dgvUpcomingEvents.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpcomingEvents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUpcomingEvents.Location = new System.Drawing.Point(122, 773);
            this.dgvUpcomingEvents.Name = "dgvUpcomingEvents";
            this.dgvUpcomingEvents.RowHeadersVisible = false;
            this.dgvUpcomingEvents.RowHeadersWidth = 100;
            this.dgvUpcomingEvents.RowTemplate.Height = 24;
            this.dgvUpcomingEvents.Size = new System.Drawing.Size(1630, 389);
            this.dgvUpcomingEvents.TabIndex = 5;
            // 
            // lblDigitalContentsA
            // 
            this.lblDigitalContentsA.AutoSize = true;
            this.lblDigitalContentsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalContentsA.Location = new System.Drawing.Point(117, 1218);
            this.lblDigitalContentsA.Name = "lblDigitalContentsA";
            this.lblDigitalContentsA.Size = new System.Drawing.Size(286, 25);
            this.lblDigitalContentsA.TabIndex = 0;
            this.lblDigitalContentsA.Text = "Digital Contents Anouncements";
            // 
            // lblAllBenefitsAvailable
            // 
            this.lblAllBenefitsAvailable.AutoSize = true;
            this.lblAllBenefitsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBenefitsAvailable.Location = new System.Drawing.Point(952, 376);
            this.lblAllBenefitsAvailable.Name = "lblAllBenefitsAvailable";
            this.lblAllBenefitsAvailable.Size = new System.Drawing.Size(194, 25);
            this.lblAllBenefitsAvailable.TabIndex = 0;
            this.lblAllBenefitsAvailable.Text = "All Benefits Available";
            // 
            // lblAllBenefitsUsed
            // 
            this.lblAllBenefitsUsed.AutoSize = true;
            this.lblAllBenefitsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBenefitsUsed.Location = new System.Drawing.Point(117, 376);
            this.lblAllBenefitsUsed.Name = "lblAllBenefitsUsed";
            this.lblAllBenefitsUsed.Size = new System.Drawing.Size(160, 25);
            this.lblAllBenefitsUsed.TabIndex = 0;
            this.lblAllBenefitsUsed.Text = "All Benefits Used";
            // 
            // lblUpComingEvent
            // 
            this.lblUpComingEvent.AutoSize = true;
            this.lblUpComingEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpComingEvent.Location = new System.Drawing.Point(117, 735);
            this.lblUpComingEvent.Name = "lblUpComingEvent";
            this.lblUpComingEvent.Size = new System.Drawing.Size(165, 25);
            this.lblUpComingEvent.TabIndex = 0;
            this.lblUpComingEvent.Text = "Upcoming Events";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEventJoinedCount);
            this.panel1.Controls.Add(this.lblTotalEvent);
            this.panel1.Location = new System.Drawing.Point(122, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 258);
            this.panel1.TabIndex = 4;
            // 
            // lblEventJoinedCount
            // 
            this.lblEventJoinedCount.AutoSize = true;
            this.lblEventJoinedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventJoinedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(24)))), ((int)(((byte)(96)))));
            this.lblEventJoinedCount.Location = new System.Drawing.Point(200, 61);
            this.lblEventJoinedCount.Name = "lblEventJoinedCount";
            this.lblEventJoinedCount.Size = new System.Drawing.Size(70, 76);
            this.lblEventJoinedCount.TabIndex = 0;
            this.lblEventJoinedCount.Text = "0";
            // 
            // lblTotalEvent
            // 
            this.lblTotalEvent.AutoSize = true;
            this.lblTotalEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEvent.Location = new System.Drawing.Point(152, 194);
            this.lblTotalEvent.Name = "lblTotalEvent";
            this.lblTotalEvent.Size = new System.Drawing.Size(185, 25);
            this.lblTotalEvent.TabIndex = 0;
            this.lblTotalEvent.Text = "Total Events Joined";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1837, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 409);
            this.panel2.TabIndex = 4;
            // 
            // panelBenefitsAvailable
            // 
            this.panelBenefitsAvailable.BackColor = System.Drawing.Color.White;
            this.panelBenefitsAvailable.Controls.Add(this.lblAvailableCount);
            this.panelBenefitsAvailable.Controls.Add(this.labelBenefitsAvailable);
            this.panelBenefitsAvailable.Location = new System.Drawing.Point(1240, 91);
            this.panelBenefitsAvailable.Name = "panelBenefitsAvailable";
            this.panelBenefitsAvailable.Size = new System.Drawing.Size(512, 258);
            this.panelBenefitsAvailable.TabIndex = 4;
            // 
            // lblAvailableCount
            // 
            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(24)))), ((int)(((byte)(96)))));
            this.lblAvailableCount.Location = new System.Drawing.Point(223, 61);
            this.lblAvailableCount.Name = "lblAvailableCount";
            this.lblAvailableCount.Size = new System.Drawing.Size(70, 76);
            this.lblAvailableCount.TabIndex = 0;
            this.lblAvailableCount.Text = "0";
            // 
            // labelBenefitsAvailable
            // 
            this.labelBenefitsAvailable.AllowDrop = true;
            this.labelBenefitsAvailable.AutoSize = true;
            this.labelBenefitsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenefitsAvailable.Location = new System.Drawing.Point(186, 194);
            this.labelBenefitsAvailable.Name = "labelBenefitsAvailable";
            this.labelBenefitsAvailable.Size = new System.Drawing.Size(167, 25);
            this.labelBenefitsAvailable.TabIndex = 0;
            this.labelBenefitsAvailable.Text = "Benefits Available";
            // 
            // panelBenefitsUsed
            // 
            this.panelBenefitsUsed.BackColor = System.Drawing.Color.White;
            this.panelBenefitsUsed.Controls.Add(this.lblUsedCount);
            this.panelBenefitsUsed.Controls.Add(this.labelBenefitsUsed);
            this.panelBenefitsUsed.Location = new System.Drawing.Point(678, 91);
            this.panelBenefitsUsed.Name = "panelBenefitsUsed";
            this.panelBenefitsUsed.Size = new System.Drawing.Size(512, 258);
            this.panelBenefitsUsed.TabIndex = 4;
            // 
            // lblUsedCount
            // 
            this.lblUsedCount.AutoSize = true;
            this.lblUsedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(24)))), ((int)(((byte)(96)))));
            this.lblUsedCount.Location = new System.Drawing.Point(201, 61);
            this.lblUsedCount.Name = "lblUsedCount";
            this.lblUsedCount.Size = new System.Drawing.Size(70, 76);
            this.lblUsedCount.TabIndex = 0;
            this.lblUsedCount.Text = "0";
            // 
            // labelBenefitsUsed
            // 
            this.labelBenefitsUsed.AutoSize = true;
            this.labelBenefitsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenefitsUsed.Location = new System.Drawing.Point(181, 194);
            this.labelBenefitsUsed.Name = "labelBenefitsUsed";
            this.labelBenefitsUsed.Size = new System.Drawing.Size(133, 25);
            this.labelBenefitsUsed.TabIndex = 0;
            this.labelBenefitsUsed.Text = "Benefits Used";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1098, 596);
            this.Controls.Add(this.panelNested);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelNested.ResumeLayout(false);
            this.panelNested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefitsAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenefitsUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBenefitsAvailable.ResumeLayout(false);
            this.panelBenefitsAvailable.PerformLayout();
            this.panelBenefitsUsed.ResumeLayout(false);
            this.panelBenefitsUsed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelNested;
        private System.Windows.Forms.Panel panelBenefitsUsed;
        private System.Windows.Forms.Label lblUsedCount;
        private System.Windows.Forms.Label labelBenefitsUsed;
        private System.Windows.Forms.Panel panelBenefitsAvailable;
        private System.Windows.Forms.Label lblAvailableCount;
        private System.Windows.Forms.Label labelBenefitsAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventJoinedCount;
        private System.Windows.Forms.Label lblTotalEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstDigitalContent;
        private System.Windows.Forms.DataGridView dgvUpcomingEvents;
        private System.Windows.Forms.Label lblUpComingEvent;
        private System.Windows.Forms.Label lblDigitalContentsA;
        private System.Windows.Forms.DataGridView dgvBenefitsUsed;
        private System.Windows.Forms.DataGridView dgvBenefitsAvailable;
        private System.Windows.Forms.Label lblAllBenefitsAvailable;
        private System.Windows.Forms.Label lblAllBenefitsUsed;
    }
}