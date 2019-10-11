namespace Passku.ManagerApp.Scenes
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwReports = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgwMessages = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInformations = new System.Windows.Forms.Button();
            this.btnShowMembers = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnCreateAnnouncement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgwAnnouncements = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCountMembers = new System.Windows.Forms.Label();
            this.lblCountAnnouncements = new System.Windows.Forms.Label();
            this.lblCountMessages = new System.Windows.Forms.Label();
            this.lblCountReports = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReports)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnnouncements)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgwReports);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 350);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(737, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duyurular";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwReports
            // 
            this.dgwReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReports.Location = new System.Drawing.Point(19, 43);
            this.dgwReports.Name = "dgwReports";
            this.dgwReports.RowTemplate.Height = 24;
            this.dgwReports.Size = new System.Drawing.Size(671, 288);
            this.dgwReports.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 350);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgwMessages);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 350);
            this.panel4.TabIndex = 3;
            // 
            // dgwMessages
            // 
            this.dgwMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMessages.Location = new System.Drawing.Point(19, 43);
            this.dgwMessages.Name = "dgwMessages";
            this.dgwMessages.RowTemplate.Height = 24;
            this.dgwMessages.Size = new System.Drawing.Size(671, 288);
            this.dgwMessages.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(700, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Messages";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(671, 288);
            this.dataGridView2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Messages";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnInformations);
            this.panel3.Controls.Add(this.btnShowMembers);
            this.panel3.Controls.Add(this.btnSendMessage);
            this.panel3.Controls.Add(this.btnCreateAnnouncement);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(746, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 217);
            this.panel3.TabIndex = 3;
            // 
            // btnInformations
            // 
            this.btnInformations.Location = new System.Drawing.Point(346, 134);
            this.btnInformations.Name = "btnInformations";
            this.btnInformations.Size = new System.Drawing.Size(223, 46);
            this.btnInformations.TabIndex = 7;
            this.btnInformations.Text = "Informations";
            this.btnInformations.UseVisualStyleBackColor = true;
            // 
            // btnShowMembers
            // 
            this.btnShowMembers.Location = new System.Drawing.Point(346, 61);
            this.btnShowMembers.Name = "btnShowMembers";
            this.btnShowMembers.Size = new System.Drawing.Size(223, 46);
            this.btnShowMembers.TabIndex = 6;
            this.btnShowMembers.Text = "Show Members";
            this.btnShowMembers.UseVisualStyleBackColor = true;
            this.btnShowMembers.Click += new System.EventHandler(this.btnShowMembers_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(8, 134);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(223, 46);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnCreateAnnouncement
            // 
            this.btnCreateAnnouncement.Location = new System.Drawing.Point(8, 61);
            this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(223, 46);
            this.btnCreateAnnouncement.TabIndex = 4;
            this.btnCreateAnnouncement.Text = "Create Announcement";
            this.btnCreateAnnouncement.UseVisualStyleBackColor = true;
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operations";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgwAnnouncements);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(742, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 350);
            this.panel5.TabIndex = 8;
            // 
            // dgwAnnouncements
            // 
            this.dgwAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAnnouncements.Location = new System.Drawing.Point(12, 43);
            this.dgwAnnouncements.Name = "dgwAnnouncements";
            this.dgwAnnouncements.RowTemplate.Height = 24;
            this.dgwAnnouncements.Size = new System.Drawing.Size(561, 288);
            this.dgwAnnouncements.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(575, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Announcements";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblCountMembers);
            this.panel6.Controls.Add(this.lblCountAnnouncements);
            this.panel6.Controls.Add(this.lblCountMessages);
            this.panel6.Controls.Add(this.lblCountReports);
            this.panel6.Location = new System.Drawing.Point(746, 236);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(583, 126);
            this.panel6.TabIndex = 9;
            // 
            // lblCountMembers
            // 
            this.lblCountMembers.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountMembers.Location = new System.Drawing.Point(3, 90);
            this.lblCountMembers.Name = "lblCountMembers";
            this.lblCountMembers.Size = new System.Drawing.Size(575, 30);
            this.lblCountMembers.TabIndex = 11;
            this.lblCountMembers.Text = "Members Count : 0";
            this.lblCountMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountAnnouncements
            // 
            this.lblCountAnnouncements.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountAnnouncements.Location = new System.Drawing.Point(3, 60);
            this.lblCountAnnouncements.Name = "lblCountAnnouncements";
            this.lblCountAnnouncements.Size = new System.Drawing.Size(575, 30);
            this.lblCountAnnouncements.TabIndex = 10;
            this.lblCountAnnouncements.Text = "Announcements Count : 0";
            this.lblCountAnnouncements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountMessages
            // 
            this.lblCountMessages.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountMessages.Location = new System.Drawing.Point(3, 30);
            this.lblCountMessages.Name = "lblCountMessages";
            this.lblCountMessages.Size = new System.Drawing.Size(575, 30);
            this.lblCountMessages.TabIndex = 9;
            this.lblCountMessages.Text = "Messages Count : 0";
            this.lblCountMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountReports
            // 
            this.lblCountReports.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountReports.Location = new System.Drawing.Point(3, 0);
            this.lblCountReports.Name = "lblCountReports";
            this.lblCountReports.Size = new System.Drawing.Size(575, 30);
            this.lblCountReports.TabIndex = 8;
            this.lblCountReports.Text = "Reports Count : 0";
            this.lblCountReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 735);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passku Manager App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReports)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAnnouncements)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnCreateAnnouncement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInformations;
        private System.Windows.Forms.Button btnShowMembers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgwMessages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgwAnnouncements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCountMembers;
        private System.Windows.Forms.Label lblCountAnnouncements;
        private System.Windows.Forms.Label lblCountMessages;
        private System.Windows.Forms.Label lblCountReports;
    }
}