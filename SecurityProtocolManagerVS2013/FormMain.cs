using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProtocolManagerVS2013
{
	/// <summary>
	/// Form for managing Visual Studio SecurityProtocol values
	/// </summary>
	public partial class FormMain : Form
	{
		/// <summary>
		/// Prefix for security protocol checkboxes
		/// </summary>
		public const string CHECKBOX_PREFIX = "cboSecurityProtocolType_";

		/// <summary>
		/// Initializes a new instance of the <see cref="FormMain"/> class.
		/// </summary>
		public FormMain()
		{
			InitializeComponent();
		}

		#region Form Load

		private void FormMain_Load(object sender, EventArgs e)
		{
			List<SecurityProtocolType> lst = EnumHelper<SecurityProtocolType>.EnumToIEnumerable().ToList();

			SecurityProtocolType current = ServicePointManager.SecurityProtocol;

			foreach ( SecurityProtocolType spt in lst )
			{
				CheckBox cb = new CheckBox()
				{
					Text = spt.ToString(),
					Name = string.Format("{0}{1}", CHECKBOX_PREFIX, spt.ToString()),
					Checked = (spt == (current & spt)),
					Tag = spt
				};

				this.flpProtocols.Controls.Add(cb);
			}
		}

		#endregion

		#region ApplySettings

		/// <summary>
		/// Assign the selected security protocols via a static property of ServicePointManager for
		/// this instance of Visual Studio
		/// </summary>
		private void ApplySettings(object sender, EventArgs e)
		{
			// gather values
			SecurityProtocolType? res = null;
			foreach ( Control ctrl in this.flpProtocols.Controls )
			{
				if ( (ctrl is CheckBox) 
					&& ctrl.Name.StartsWith(CHECKBOX_PREFIX, StringComparison.CurrentCultureIgnoreCase) 
					&& ((CheckBox)ctrl).Checked)
				{
					if ( !res.HasValue )
						res = (SecurityProtocolType)((CheckBox)ctrl).Tag;
					else
						res = res.Value | (SecurityProtocolType)((CheckBox)ctrl).Tag;
				}
			}

			// At least one value has to be selected; turning *all* of them off is not a valid state.
			if(!res.HasValue)
			{
				MessageBox.Show("At least one security protocol type must be selected!", "No option selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Assign value
			ServicePointManager.SecurityProtocol = res.Value;

			// cleanup 
			if ( this.Modal )
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			else
				this.Close();
		}

		#endregion

		#region Cancel

		/// <summary>
		/// Cleanup, in the case wherein the user changes their mind.
		/// </summary>
		private void Cancel(object sender, EventArgs e)
		{
			// no logic needed here when shown as a dialog, thanks to form wiring
			if ( !this.Modal )
				this.Close();
		}

		#endregion
	}
}
