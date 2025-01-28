namespace Practica10.views;

public partial class Help : ContentPage
{
	public Help()
	{
		InitializeComponent();
	}

    private async void GoBack(object sender, EventArgs e)
    {
		await Shell.Current.Navigation.PopAsync();
    }
}