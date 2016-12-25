using Xamarin.Forms;

namespace FreeTravelers
{
	public class FreeTravelersPage : MasterDetailPage
	{
		public FreeTravelersPage()
		{
			var masterPage = new MenuPage();
			Master = masterPage;
			Detail = new NavigationPage(new ToursPage());

			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as TextCell;
			if (item != null)
			{
				
			}
		}
	}
}
