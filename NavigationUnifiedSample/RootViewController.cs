using System;
using System.Drawing;
using UIKit;
using System.Threading.Tasks;
using BigTed;

namespace RRPG
{
	public partial class RootViewController : UIViewController
	{
		// the sidebar controller for the app
		public SidebarNavigation.SidebarController SidebarController { get; private set; }

		// the navigation controller
		public NavController NavController { get; private set; }

		public RootViewController() : base(null, null)
		{
		}

		public static async Task Sleep() {
			float progress = 0;

			await Task.Delay (500);
			progress += 0.25f;
			BTProgressHUD.Show("Récupération des infos", progress);
			await Task.Delay (500);
			progress += 0.25f;
			BTProgressHUD.Show("Récupération des infos", progress);
			await Task.Delay (500);
			progress += 0.25f;
			BTProgressHUD.Show("Récupération des infos", progress);
			await Task.Delay (500);
			progress += 0.25f;
			BTProgressHUD.Show("Récupération des infos", progress);
			await Task.Delay (50);
			BTProgressHUD.Dismiss ();
		}

			
		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();
			BTProgressHUD.Show("Récupération des infos", 0);

			await Sleep();

			// create a slideout navigation controller with the top navigation controller and the menu view controller
			NavController = new NavController();
			NavController.PushViewController(new IntroController(), false);
			SidebarController = new SidebarNavigation.SidebarController(this, NavController, new SideMenuController());
			SidebarController.MenuWidth = 220;
			SidebarController.ReopenOnRotate = false;
		}
	}
}

