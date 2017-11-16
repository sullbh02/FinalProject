namespace Hoard
{
    partial class Form1
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
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnNewAsset = new System.Windows.Forms.Button();
            this.dgvRecentTickets = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTicketsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAssetsForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTickets)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Location = new System.Drawing.Point(152, 289);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(110, 23);
            this.btnNewTicket.TabIndex = 0;
            this.btnNewTicket.Text = "Create Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnNewAsset
            // 
            this.btnNewAsset.Location = new System.Drawing.Point(268, 289);
            this.btnNewAsset.Name = "btnNewAsset";
            this.btnNewAsset.Size = new System.Drawing.Size(110, 23);
            this.btnNewAsset.TabIndex = 1;
            this.btnNewAsset.Text = "Add Asset ";
            this.btnNewAsset.UseVisualStyleBackColor = true;
            this.btnNewAsset.Click += new System.EventHandler(this.btnNewAsset_Click);
            // 
            // dgvRecentTickets
            // 
            this.dgvRecentTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentTickets.Location = new System.Drawing.Point(12, 36);
            this.dgvRecentTickets.Name = "dgvRecentTickets";
            this.dgvRecentTickets.Size = new System.Drawing.Size(524, 247);
            this.dgvRecentTickets.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsQuit
            // 
            this.tsQuit.Name = "tsQuit";
            this.tsQuit.Size = new System.Drawing.Size(152, 22);
            this.tsQuit.Text = "Quit";
            this.tsQuit.Click += new System.EventHandler(this.tsQuit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTicketsForm,
            this.tsAssetsForm});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tsTicketsForm
            // 
            this.tsTicketsForm.Name = "tsTicketsForm";
            this.tsTicketsForm.Size = new System.Drawing.Size(152, 22);
            this.tsTicketsForm.Text = "Tickets";
            this.tsTicketsForm.Click += new System.EventHandler(this.tsTicketsForm_Click);
            // 
            // tsAssetsForm
            // 
            this.tsAssetsForm.Name = "tsAssetsForm";
            this.tsAssetsForm.Size = new System.Drawing.Size(152, 22);
            this.tsAssetsForm.Text = "Assets";
            this.tsAssetsForm.Click += new System.EventHandler(this.tsAssetsForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRecentTickets);
            this.Controls.Add(this.btnNewAsset);
            this.Controls.Add(this.btnNewTicket);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hoard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTickets)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnNewAsset;
        private System.Windows.Forms.DataGridView dgvRecentTickets;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsQuit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTicketsForm;
        private System.Windows.Forms.ToolStripMenuItem tsAssetsForm;
    }
}

