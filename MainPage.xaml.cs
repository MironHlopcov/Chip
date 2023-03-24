namespace Chip;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		MyChip.CloseButtonClicked += MyChip_CloseButtonCliced;
        MyChip.Checkd += MyChip_Checkd;
        var lis = new List<IView>();
        lis.Add(MyChip);
        ChipCont.ChipList = lis;
    }

    private void MyChip_Checkd(object sender, EventArgs e)
    {
        
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		MyChip.IsChacked = true;
	}

    private void MyChip_CloseButtonCliced(object sender, EventArgs e)
    {
        //RootLayout.Children.Remove(MyChip);
    }

    private void ChipButton_Clicked(object sender, EventArgs e)
    {
		
		
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {

    }
}

