using Xamarin.Forms;

namespace FreeTravelers
{
	public class FreeTravelersPage : MasterDetailPage
	{

		MenuPage masterPage;

		public FreeTravelersPage()
		{
			masterPage = new MenuPage();
			Master = masterPage;
			Detail = new NavigationPage(new ToursPage());

			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MenuItem;
			if (item != null)
			{
				if (item.Text == "About us")
				{
					DisplayAlert("About us", "We are FreeTravelers team", "OK");
					return;
				}
				if (item.Text == "About app")
				{
					DisplayAlert("About app", "FreeTravelers app version 0.1", "OK");
					return;
				}
				Detail = new NavigationPage((Page)System.Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
