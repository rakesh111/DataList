using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;
using System.Collections;


namespace DataList
{
	public partial class MyPage : ContentPage
	{
		private ViewModel _viewModel = new ViewModel ();
		public MyPage ()
		{
			InitializeComponent ();
			this.BindingContext = this._viewModel.Items;
		}
		protected void ItemAppearing(object sender, ItemVisibilityEventArgs e)
		{

			var items = this.BindingContext as IList;
			if (items != null && e.Item == items [items.Count - 1]) {
				this._viewModel.Load ();
                
                
			}
            

		}
	}
}


