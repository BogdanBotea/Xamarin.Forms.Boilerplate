using System;
using Xamarin.Forms;

namespace Boilerplate.Core
{
	public class MasterPageItem
	{
		public string Title 
		{ 
			get; 
			set;
		}

		public ImageSource IconSource 
		{ 
			get;
			set; 
		}

		public Type TargetType 
		{ 
			get; 
			set; 
		}

		public static MasterPageItem Module1
		{
			get
			{
				return new MasterPageItem()
				{
					Title = "Module1",
					IconSource = "Pie Chart Filled.png", // or ImageSource.FromResource("module1Icon.png")
					TargetType = typeof(Module1TabbedPage)
				};
			}
		}

		public static MasterPageItem Module2
		{
			get
			{
				return new MasterPageItem()
				{
					Title = "Module2",
					IconSource = "Bank Cards Filled.png", // or ImageSource.FromResource("module2Icon.png")
					TargetType = typeof(Module2Page) 
				};
			}
		}
	}
}

