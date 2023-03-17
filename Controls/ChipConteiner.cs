using Microsoft.Maui.Layouts;

namespace Chip.Controls;

public class ChipConteiner : ContentView
{
	public ChipConteiner()
	{
		Content = new StackLayout
		{
		

			Children =
			{
				new Label { Text = "Welcome to .NET MAUI!" },
				
			}
		};
	}
}