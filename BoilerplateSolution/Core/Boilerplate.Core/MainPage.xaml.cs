using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Boilerplate.Core
{
	public partial class MainPage : MasterDetailPage
	{
		private string ColorSetting
		{
			get
			{
				// This color can be retrieved from settings
				return "#494949";
			}
		}

		public MainPage()
		{
			InitializeComponent();
			InitializeMaster();
		}

		public void InitializeMaster()
		{
			SelectApplicationFirstPage();

			masterPage.MasterListView.ItemSelected += OnItemSelected;

			// Following code is for those who want a functional settings page
			//var settingsLabelTap = new TapGestureRecognizer();
			//settingsLabelTap.Tapped += (s, e) =>
			//{
			//	Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SettingsPage)))
			//	{
			//		BarBackgroundColor = Color.FromHex(ColorSetting),
			//		BarTextColor = Color.White,
			//		BackgroundColor = Color.FromHex(ColorSetting)
			//	};
			//	masterPage.MasterListView.SelectedItem = null;
			//	IsPresented = false;
			//};
			//masterPage.MasterSettings.GestureRecognizers.Add(settingsLabelTap);
		}

		private void SelectApplicationFirstPage()
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Module1TabbedPage)))
			{
				BarBackgroundColor = Color.FromHex(ColorSetting),
				BarTextColor = Color.White,
				BackgroundColor = Color.FromHex(ColorSetting)
			};
			masterPage.MasterListView.SelectedItem = null;
			IsPresented = false;
		}

		private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
				{
					BarBackgroundColor = Color.FromHex(ColorSetting),
					BarTextColor = Color.White,
					BackgroundColor = Color.FromHex(ColorSetting)
				};
				masterPage.MasterListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}