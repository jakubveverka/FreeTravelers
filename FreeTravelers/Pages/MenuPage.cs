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

			var menuPageItems = new List<MenuItem>();
			menuPageItems.Add(new MenuItem
			{
				Text = "Tours",
				TargetType = typeof(ToursPage)
			});
			menuPageItems.Add(new MenuItem
			{
				Text = "Create tour",
				TargetType = typeof(CreateTourPage)
			});
			menuPageItems.Add(new MenuItem
			{
				Text = "Account",
				TargetType = typeof(AccountPage)
			});
			menuPageItems.Add(new MenuItem
			{
				Text = "About us"
			});
			menuPageItems.Add(new MenuItem
			{
				Text = "About app"
			});

			listView.ItemsSource = menuPageItems;
		}
	}
}