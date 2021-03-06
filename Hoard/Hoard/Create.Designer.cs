﻿namespace Hoard
{
    partial class Create
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTicketLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTicket = new System.Windows.Forms.CheckBox();
            this.chkAsset = new System.Windows.Forms.CheckBox();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbTicket = new System.Windows.Forms.GroupBox();
            this.lstType = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.grbAsset = new System.Windows.Forms.GroupBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssetLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstAsset = new System.Windows.Forms.ListBox();
            this.grbType.SuspendLayout();
            this.grbTicket.SuspendLayout();
            this.grbAsset.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(209, 359);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTicketLocation
            // 
            this.txtTicketLocation.Location = new System.Drawing.Point(70, 51);
            this.txtTicketLocation.Name = "txtTicketLocation";
            this.txtTicketLocation.Size = new System.Drawing.Size(100, 20);
            this.txtTicketLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            // 
            // chkTicket
            // 
            this.chkTicket.AutoSize = true;
            this.chkTicket.Location = new System.Drawing.Point(0, 19);
            this.chkTicket.Name = "chkTicket";
            this.chkTicket.Size = new System.Drawing.Size(56, 17);
            this.chkTicket.TabIndex = 3;
            this.chkTicket.Text = "Ticket";
            this.chkTicket.UseVisualStyleBackColor = true;
            this.chkTicket.CheckedChanged += new System.EventHandler(this.chkTicket_CheckedChanged);
            // 
            // chkAsset
            // 
            this.chkAsset.AutoSize = true;
            this.chkAsset.Location = new System.Drawing.Point(0, 42);
            this.chkAsset.Name = "chkAsset";
            this.chkAsset.Size = new System.Drawing.Size(52, 17);
            this.chkAsset.TabIndex = 4;
            this.chkAsset.Text = "Asset";
            this.chkAsset.UseVisualStyleBackColor = true;
            this.chkAsset.CheckedChanged += new System.EventHandler(this.chkAsset_CheckedChanged);
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.chkTicket);
            this.grbType.Controls.Add(this.chkAsset);
            this.grbType.Location = new System.Drawing.Point(200, 47);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(97, 78);
            this.grbType.TabIndex = 5;
            this.grbType.TabStop = false;
            this.grbType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // grbTicket
            // 
            this.grbTicket.Controls.Add(this.lstType);
            this.grbTicket.Controls.Add(this.txtDescription);
            this.grbTicket.Controls.Add(this.label5);
            this.grbTicket.Controls.Add(this.label4);
            this.grbTicket.Controls.Add(this.txtTicketLocation);
            this.grbTicket.Controls.Add(this.label1);
            this.grbTicket.Controls.Add(this.label3);
            this.grbTicket.Controls.Add(this.txtUser);
            this.grbTicket.Enabled = false;
            this.grbTicket.Location = new System.Drawing.Point(12, 131);
            this.grbTicket.Name = "grbTicket";
            this.grbTicket.Size = new System.Drawing.Size(229, 222);
            this.grbTicket.TabIndex = 6;
            this.grbTicket.TabStop = false;
            this.grbTicket.Text = "Ticket Information";
            // 
            // lstType
            // 
            this.lstType.FormattingEnabled = true;
            this.lstType.Items.AddRange(new object[] {
            "Computer",
            "Printer",
            "AV",
            "iPad",
            "Miscellaneous"});
            this.lstType.Location = new System.Drawing.Point(70, 73);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(100, 69);
            this.lstType.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(70, 154);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(153, 62);
            this.txtDescription.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(70, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // grbAsset
            // 
            this.grbAsset.Controls.Add(this.lstAsset);
            this.grbAsset.Controls.Add(this.txtSN);
            this.grbAsset.Controls.Add(this.label6);
            this.grbAsset.Controls.Add(this.label7);
            this.grbAsset.Controls.Add(this.txtAssetLocation);
            this.grbAsset.Controls.Add(this.label8);
            this.grbAsset.Controls.Add(this.label9);
            this.grbAsset.Controls.Add(this.txtAssetName);
            this.grbAsset.Enabled = false;
            this.grbAsset.Location = new System.Drawing.Point(260, 131);
            this.grbAsset.Name = "grbAsset";
            this.grbAsset.Size = new System.Drawing.Size(229, 222);
            this.grbAsset.TabIndex = 7;
            this.grbAsset.TabStop = false;
            this.grbAsset.Text = "Asset Information";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(73, 179);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 20);
            this.txtSN.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "S/N:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type:";
            // 
            // txtAssetLocation
            // 
            this.txtAssetLocation.Location = new System.Drawing.Point(73, 52);
            this.txtAssetLocation.Name = "txtAssetLocation";
            this.txtAssetLocation.Size = new System.Drawing.Size(100, 20);
            this.txtAssetLocation.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Location:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name:";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(73, 29);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(100, 20);
            this.txtAssetName.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lstAsset
            // 
            this.lstAsset.FormattingEnabled = true;
            this.lstAsset.Items.AddRange(new object[] {
            "Computer",
            "Printer",
            "Projector",
            "iPad",
            "AP",
            "Switch",
            "Miscellaneous"});
            this.lstAsset.Location = new System.Drawing.Point(73, 78);
            this.lstAsset.Name = "lstAsset";
            this.lstAsset.Size = new System.Drawing.Size(100, 95);
            this.lstAsset.TabIndex = 14;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbAsset);
            this.Controls.Add(this.grbTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.btnCreate);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbTicket.ResumeLayout(false);
            this.grbTicket.PerformLayout();
            this.grbAsset.ResumeLayout(false);
            this.grbAsset.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTicketLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTicket;
        private System.Windows.Forms.CheckBox chkAsset;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbTicket;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox grbAsset;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssetLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ListBox lstType;
        private System.Windows.Forms.ListBox lstAsset;
    }
}