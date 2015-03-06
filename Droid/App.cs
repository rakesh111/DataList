using System;
using Parse;

namespace DataList.Droid
{
	public class App
	{
		public async void ViewDidLoad()
		{
			var itemList = new ParseObject("ItemList");
			itemList["ItemName"]="Bat";
			await itemList.SaveAsync ();
		}
	}
}

