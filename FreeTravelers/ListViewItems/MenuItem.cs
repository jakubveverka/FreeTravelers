using Xamarin.Forms;
namespace FreeTravelers
{
	public class MenuItem : TextCell
	{
		public System.Type TargetType;

		public MenuItem()
		{

		}

		public MenuItem(string text, System.Type targetType)
		{
			Text = text;
			TargetType = targetType;
		}
	}
}
