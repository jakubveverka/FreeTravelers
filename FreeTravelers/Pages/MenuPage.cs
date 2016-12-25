using System.Collections.Generic;

using Xamarin.Forms;

namespace FreeTravelers
{
	public partial class MenuPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MenuPage()
		{
			InitializeComponent();

			var menuPageItems = new List<TextCell>();
			menuPageItems.Add(new TextCell
			{
				Text = "Contacts"
			});

			listView.ItemsSource = menuPageItems;
		}
	}
}