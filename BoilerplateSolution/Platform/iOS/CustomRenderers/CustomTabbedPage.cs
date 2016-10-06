using System;
using Boilerplate.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPage))]
namespace Boilerplate.iOS
{
    public class CustomTabbedPage : TabbedRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            if (TabBar == null) return;
            if (TabBar.Items == null) return;

            var tabs = Element as TabbedPage;
            if (tabs != null)
            {
                for (int i = 0; i < TabBar.Items.Length; i++)
                {
                    UpdateItem(TabBar.Items[i], tabs.Children[i].Icon);
                }
            }

            base.ViewWillAppear(animated);
        }

        private void UpdateItem(UITabBarItem item, string icon)
        {
            if (item == null)
                return;
            try
            {
                icon = icon.Replace(".png", " Filled.png");
                if (item == null) return;
                if (item.SelectedImage == null) return;
                if (item.SelectedImage.AccessibilityIdentifier == icon) return;
                item.SelectedImage = UIImage.FromBundle(icon);
                item.SelectedImage.AccessibilityIdentifier = icon;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to set selected icon: " + ex);
            }

        }
    }
}

