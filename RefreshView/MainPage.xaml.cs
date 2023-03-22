namespace RefreshView;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		count++;
	}
}

