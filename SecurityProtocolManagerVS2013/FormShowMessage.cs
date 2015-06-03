using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecurityProtocolManagerVS2013
{
	public partial class FormShowMessage : Form
	{
		public FormShowMessage()
		{
			InitializeComponent();
			this.ShowCancelButton = false;
			this.IsDialog = true;
		}

		protected bool IsDialog { get; set; }

		public List<string> Messages { get; set; }
		public string Caption { get; set; }
		public string HeaderMessage { get; set; }

		public bool ShowCancelButton { get; set; }

		public MessageBoxIcon? DisplayIcon { get; set; }

		private Icon GetSysIcon(MessageBoxIcon eval)
		{
			switch ( eval )
			{
				case MessageBoxIcon.Error:
					return SystemIcons.Error;
				case MessageBoxIcon.Exclamation:
					return SystemIcons.Exclamation;
				case MessageBoxIcon.Question:
					return SystemIcons.Question;
 				default:
					return SystemIcons.Information;
			}
		}

		public void DoRefresh()
		{
			this.Text = Caption;
			this.lblHeaderText.Text = HeaderMessage;

			//this.DisplayIcon.ToBitmap()
			if ( this.DisplayIcon.HasValue )
				this.pbIcon.Image = Bitmap.FromHicon(this.GetSysIcon(this.DisplayIcon.Value).Handle);
			else
				this.pbIcon.Visible = false;

			if ( this.ShowCancelButton )
				this.btnCancel.Visible = true;
			else
				this.btnCancel.Visible = false;

			this.rtbMessage.Clear();
			foreach ( string s in Messages )
				rtbMessage.AppendText(string.Format("{0}{1}{1}", s, Environment.NewLine));
		}

		private void FormShowMessage_Load(object sender, EventArgs e)
		{
			this.DoRefresh();
		}

		private void rtbMessage_DoubleClick(object sender, EventArgs e)
		{
			this.rtbMessage.SelectAll();
		}

		private void copySelectedTextToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			//Application.OleRequired();
			string toCopy = this.rtbMessage.SelectedText;
			if ( string.IsNullOrWhiteSpace(toCopy) )
				toCopy = this.rtbMessage.Text;
			Clipboard.SetText(toCopy);
		}

		#region static display methods

		public static DialogResult ShowError(string message, string caption = "Error", string headerMessage = "Error(s) Encountered:", MessageBoxIcon? icon = null)
		{
			return FormShowMessage.ShowError(message.Solo(), caption, headerMessage, icon);
		}

		public static DialogResult ShowError(Exception ex, string caption = "Error", string headerMessage = "Exception Encountered:", MessageBoxIcon? icon = null)
		{
			return FormShowMessage.ShowError(ex.ExceptionDump(), caption, headerMessage, icon);
		}

		public static DialogResult ShowError(IEnumerable<string> messages, string caption = "Error", string headerMessage = "Error(s) Encountered:", MessageBoxIcon? icon = null)
		{
			return FormShowMessage.ShowError(messages.ToList(), caption, headerMessage, false, icon);
		}

		public static DialogResult ShowError(List<string> messages, string caption = "Error", string headerMessage = "Error(s) Encountered:", bool allowCancel = false, MessageBoxIcon? icon = null)
		{
			return FormShowMessage.Show(messages, caption, headerMessage, allowCancel, icon);
		}

		public static DialogResult Show(string message, string caption = "Message", string headerMessage = "Message:", bool allowCancel = false, MessageBoxIcon? icon = null)
		{
			return FormShowMessage.Show(message.Solo(), caption, headerMessage, allowCancel, icon);
		}

		public static DialogResult Show(IEnumerable<string> messages, string caption = "Message", string headerMessage = "Message:", bool allowCancel = false, MessageBoxIcon? icon = null)
		{
			return FormShowMessage.Show(messages.ToList(), caption, headerMessage, allowCancel, icon);
		}

		public static DialogResult Show(List<string> messages, string caption = "Message", string headerMessage = "Message:", bool allowCancel = false, MessageBoxIcon? icon = null)
		{
			using ( FormShowMessage fts = new FormShowMessage() 
			{ 
				Messages = messages, 
				Caption = caption, 
				HeaderMessage = headerMessage,
				DisplayIcon = icon
			} )
			{
				fts.ShowCancelButton = allowCancel;
				fts.BringToFront();
				return fts.ShowDialog();
			}
		}

		public static FormShowMessage ShowNoDialog(string message, string caption = "Message", string headerMessage = "Message:", bool allowCancel = false)
		{
			return FormShowMessage.ShowNoDialog(message.Solo().ToList(), caption, headerMessage, allowCancel);
		}

		public static FormShowMessage ShowNoDialog(List<string> messages, string caption = "Message", string headerMessage = "Message:", bool allowCancel = false)
		{
			FormShowMessage fts = new FormShowMessage() { Messages = messages, Caption = caption, HeaderMessage = headerMessage };
			fts.ShowCancelButton = allowCancel;
			fts.Show();
			fts.IsDialog = false;
			fts.BringToFront();

			return fts;
		}

		#endregion

		private void btnOK_Click(object sender, EventArgs e)
		{
			if ( this.IsDialog )
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			else
				this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if ( this.IsDialog )
				this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			else
				this.Close();
		}


	}
}
