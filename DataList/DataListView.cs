using System;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections;

namespace DataList
{
	public class DataListView : ListView
	{
		public static readonly BindableProperty LoadCommandProperty = BindableProperty.Create<DataListView, ICommand>(bp => bp.LoadCommand, default(ICommand));
		public ICommand LoadCommand {
			get{ return (ICommand)this.GetValue (LoadCommandProperty); }
			set{ this.SetValue (LoadCommandProperty, value); }
		}
		public DataListView ()
		{
			this.ItemAppearing += (object sender, ItemVisibilityEventArgs e) => {
				var items = this.ItemsSource as IList;
				if(items != null && e.Item == items[items.Count - 1]){
					if(this.LoadCommand != null && this.LoadCommand.CanExecute(null))
					{
						this.LoadCommand.Execute(null);
					}
				}
			};
		}
	}
}

