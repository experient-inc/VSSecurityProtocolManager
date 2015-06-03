namespace ExperientInc.SecurityProtocolManagerVS2013Package
{
    partial class FormShowMessage
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
			this.components = new System.ComponentModel.Container();
			this.btnOK = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rtbMessage = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copySelectedTextToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblHeaderText = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnOK.Location = new System.Drawing.Point(319, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.rtbMessage, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblHeaderText, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.pbIcon, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.97059F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.02941F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 352);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// rtbMessage
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.rtbMessage, 2);
			this.rtbMessage.ContextMenuStrip = this.contextMenuStrip1;
			this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbMessage.Location = new System.Drawing.Point(3, 46);
			this.rtbMessage.Name = "rtbMessage";
			this.rtbMessage.ReadOnly = true;
			this.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbMessage.Size = new System.Drawing.Size(518, 263);
			this.rtbMessage.TabIndex = 1;
			this.rtbMessage.Text = "";
			this.rtbMessage.DoubleClick += new System.EventHandler(this.rtbMessage_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedTextToClipboardToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(225, 26);
			// 
			// copySelectedTextToClipboardToolStripMenuItem
			// 
			this.copySelectedTextToClipboardToolStripMenuItem.Name = "copySelectedTextToClipboardToolStripMenuItem";
			this.copySelectedTextToClipboardToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.copySelectedTextToClipboardToolStripMenuItem.Text = "Copy selected text to clipboard";
			this.copySelectedTextToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copySelectedTextToClipboardToolStripMenuItem_Click);
			// 
			// lblHeaderText
			// 
			this.lblHeaderText.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblHeaderText, 2);
			this.lblHeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderText.Location = new System.Drawing.Point(3, 0);
			this.lblHeaderText.Name = "lblHeaderText";
			this.lblHeaderText.Size = new System.Drawing.Size(518, 43);
			this.lblHeaderText.TabIndex = 2;
			this.lblHeaderText.Text = "Message:";
			this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnCancel);
			this.flowLayoutPanel1.Controls.Add(this.btnOK);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 315);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 34);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancel.Location = new System.Drawing.Point(400, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pbIcon
			// 
			this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbIcon.Location = new System.Drawing.Point(3, 315);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(34, 34);
			this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbIcon.TabIndex = 5;
			this.pbIcon.TabStop = false;
			// 
			// FormShowMessage
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 352);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormShowMessage";
			this.Text = "Message";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormShowMessage_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copySelectedTextToClipboardToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox pbIcon;
    }
}