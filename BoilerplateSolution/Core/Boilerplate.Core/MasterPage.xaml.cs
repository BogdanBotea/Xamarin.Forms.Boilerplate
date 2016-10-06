using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Boilerplate.Core
{
	public partial class MasterPage : ContentPage
	{
		private string ColorSetting
		{
			get
			{
				// This color can be retrieved from settings
				return "#494949";
			}
		}

		public ListView MasterListView
		{
			get { return lvItems; }
		}

		public Label MasterSettings
		{
			get { return lSettings; }
		}

		public MasterPage()
		{
			InitializeComponent();
			InitializeUI();
			InitializeList();
		}

		private void InitializeUI()
		{
			slContainer.BackgroundColor = Color.FromHex(ColorSetting);
			lSettings.BackgroundColor = Color.FromHex(ColorSetting);
		}

		private void MasterPage_Appering(object sender, EventArgs e)
		{
			InitializeUI();
		}

		private void MasterPage_Focused(object sender, EventArgs e)
		{
			InitializeUI();
		}

		private void InitializeList()
		{
			List<MasterPageItem> masterPageItems = new List<MasterPageItem>
			{
				MasterPageItem.Module1,
				MasterPageItem.Module2
			};

			lvItems.ItemsSource = masterPageItems;
		}
	}
}