namespace AppJuanDiegoSilva_MAUI;

public partial class AboutPage_JDS : ContentPage
{
	public AboutPage_JDS()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked_JDS(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }

}