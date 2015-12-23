using System;
using System.Drawing;
using UIKit;

namespace RRPG
{
	public partial class SideMenuController : BaseController
	{
		public SideMenuController() : base(null, null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.FromRGB(.9f, .9f, .9f);

			var title = new UILabel(new RectangleF(0, 50, 230, 20));
			title.Font = UIFont.SystemFontOfSize(24.0f);
			title.TextAlignment = UITextAlignment.Center;
			title.TextColor = UIColor.Blue;
			title.Text = "Menu";

			var introButton = new UIButton(UIButtonType.System);
			introButton.Frame = new RectangleF(0, 140, 230, 20);
			introButton.SetTitle("Personnages", UIControlState.Normal);
			introButton.TouchUpInside += (sender, e) => {
				NavController.PopToRootViewController(false);
				SidebarController.CloseMenu();
			};

			var contentButton = new UIButton(UIButtonType.System);
			contentButton.Frame = new RectangleF(0, 180, 230, 20);
			contentButton.SetTitle("Marché naval", UIControlState.Normal);
			contentButton.TouchUpInside += (sender, e) => {
				NavController.PushViewController(new ContentController(), false);
				SidebarController.CloseMenu();
			};

			var VillageoisButton = new UIButton(UIButtonType.System);
			VillageoisButton.Frame = new RectangleF(0, 220, 230, 20);
			VillageoisButton.SetTitle("Villageois", UIControlState.Normal);
			VillageoisButton.TouchUpInside += (sender, e) => {
				NavController.PushViewController(new ContentVillageois(), false);
				SidebarController.CloseMenu();
			};

			var RoyaumesButton = new UIButton(UIButtonType.System);
			RoyaumesButton.Frame = new RectangleF(0, 260, 230, 20);
			RoyaumesButton.SetTitle("Royaumes", UIControlState.Normal);
			RoyaumesButton.TouchUpInside += (sender, e) => {
				NavController.PushViewController(new ContentController(), false);
				SidebarController.CloseMenu();
			};


			View.Add(title);
			//View.Add(body);
			View.Add(introButton);
			View.Add(contentButton);
			View.Add(VillageoisButton);
			View.Add(RoyaumesButton);
		}
	}
}

