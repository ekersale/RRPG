using System;
using System.Drawing;
using UIKit;

namespace RRPG
{
	public partial class IntroController : BaseController
	{
		public IntroController() : base(null, null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.White;

			var title = new UILabel(new RectangleF(0, 80, 380, 30));
			title.Font = UIFont.SystemFontOfSize(24.0f);
			title.TextAlignment = UITextAlignment.Center;
			title.TextColor = UIColor.Blue;
			title.Text = "RR Informations";


			var body = new UILabel(new RectangleF(50, 150, 220, 100));
			body.Font = UIFont.SystemFontOfSize(12.0f);
			body.TextAlignment = UITextAlignment.Center;
			body.Lines = 0;
			body.Text = @"Bienvenue";

			View.Add(title);
			View.Add(body);
		}
	}
}

