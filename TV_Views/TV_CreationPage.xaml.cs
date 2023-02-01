namespace ExamenProgreso3API_ThyaraVintimilla.TV_Views;

public partial class TV_CreationPage : ContentPage
{
	public TV_CreationPage()
	{
		InitializeComponent();
	}

	private void SavedClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());
    }
}