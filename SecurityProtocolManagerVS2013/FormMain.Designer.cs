namespace SecurityProtocolManagerVS2013
{
	partial class FormMain
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
			if ( disposing && (components != null) )
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.flpProtocols = new System.Windows.Forms.FlowLayoutPanel();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtUserDetail = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flpProtocols, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnApply, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtUserDetail, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 176);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(448, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enabled Security Protocols:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flpProtocols
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flpProtocols, 3);
			this.flpProtocols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpProtocols.Location = new System.Drawing.Point(3, 23);
			this.flpProtocols.Name = "flpProtocols";
			this.flpProtocols.Size = new System.Drawing.Size(448, 66);
			this.flpProtocols.TabIndex = 1;
			// 
			// btnApply
			// 
			this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnApply.Location = new System.Drawing.Point(287, 148);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(79, 25);
			this.btnApply.TabIndex = 2;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.ApplySettings);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(372, 148);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(79, 25);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.Cancel);
			// 
			// txtUserDetail
			// 
			this.txtUserDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tableLayoutPanel1.SetColumnSpan(this.txtUserDetail, 3);
			this.txtUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUserDetail.Location = new System.Drawing.Point(3, 95);
			this.txtUserDetail.MaxLength = 0;
			this.txtUserDetail.Multiline = true;
			this.txtUserDetail.Name = "txtUserDetail";
			this.txtUserDetail.ReadOnly = true;
			this.txtUserDetail.Size = new System.Drawing.Size(448, 47);
			this.txtUserDetail.TabIndex = 4;
			this.txtUserDetail.Text = "For more information on each protocol, see\r\n\r\nhttps://msdn.microsoft.com/en-us/li" +
    "brary/system.net.securityprotocoltype(v=vs.110).aspx";
			// 
			// FormMain
			// 
			this.AcceptButton = this.btnApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(454, 176);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FormMain";
			this.Text = "Security Protocol Manager";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flpProtocols;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtUserDetail;
	}
}