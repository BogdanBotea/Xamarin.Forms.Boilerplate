using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Xamarin.Forms;

namespace Boilerplate.Core
{
	public partial class Module1TabbedPage : TabbedPage
	{
		private string ColorSetting
		{
			get
			{
				// This color can be retrieved from settings
				return "#494949";
			}
		}

		public Module1TabbedPage()
		{
			InitializeComponent();
			BarBackgroundColor = Color.FromHex(ColorSetting);
		}

		#region [ Tabbed Page Events ]

		private void Module1Page1_Appearing(object sender, EventArgs e)
		{
			this.ToolbarItems.Clear();
		}

		private void Module1Page2_Appearing(object sender, EventArgs e)
		{
			this.ToolbarItems.Clear();
		}

		#endregion
	}
}