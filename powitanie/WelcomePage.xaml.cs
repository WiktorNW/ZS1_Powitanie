namespace powitanie;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(string imieE)
	{
		InitializeComponent();

		witaj.Text = $"Witaj {imieE}!";
    }
}