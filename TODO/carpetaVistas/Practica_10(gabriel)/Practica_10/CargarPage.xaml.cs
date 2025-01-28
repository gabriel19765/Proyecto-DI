namespace Practica_10;

public partial class CargarPage : ContentPage
{
    public CargarPage()
    {
        InitializeComponent();
    }

    private async void GoToMain_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///main");
    }

    private void activar_btn(object sender, EventArgs e)
    {
        btnFaltas.IsEnabled = true;
    }

    private void ImageButton_OnClicked(object? sender, EventArgs e)
    {
        DisplayAlert("Acerca de", "Version 1.0", "OK");
    }
}