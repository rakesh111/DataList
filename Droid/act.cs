
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Parse;

namespace DataList.Droid
{
	[Activity (Label = "act")]			
	public class act : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ParseClient.Initialize("s2Qe5plZ2vpM3ET0OlvXmDLOqQ5PZDijjbCLcQwW","F3K7lRSQU72KigmQ2iXm5uVJ7c7X01AIF1bLbReF");

			// Create your application here
		}
		public async override void ViewDidLoad()
		{

			base.ViewDidLoad ();
			var itemList = new ParseObject ("ItemList");
			itemList ["ItemName"] = "ball";
			await itemList.SaveAsync ();
		}

	}
}

