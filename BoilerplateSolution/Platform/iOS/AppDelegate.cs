using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Boilerplate.Core;

namespace Boilerplate.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();


			// Selected tint color
			UITabBar.Appearance.SelectedImageTintColor = UIColor.White;

			AppOptions appOptions = new AppOptions();
			//appOption.Prop = value;

			App.Instance.Options = appOptions;
			App.Instance.InitializeUI();

			LoadApplication(App.Instance);

			return base.FinishedLaunching(app, options);
		}
	}
}
