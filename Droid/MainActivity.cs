using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Parse;


namespace DataList.Droid
{

	[Activity (Label = "DataList.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{


		protected async override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ParseClient.Initialize("s2Qe5plZ2vpM3ET0OlvXmDLOqQ5PZDijjbCLcQwW","F3K7lRSQU72KigmQ2iXm5uVJ7c7X01AIF1bLbReF");


			{
				var itemList = new ParseObject ("ItemList");
				itemList ["ItemName"] = "ball";
				await itemList.SaveAsync ();
			}

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}

	}
}

