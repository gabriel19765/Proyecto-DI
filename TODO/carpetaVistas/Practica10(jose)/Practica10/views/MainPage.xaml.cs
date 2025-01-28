namespace Practica10.views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public static string test = "testing text";

        private async void GoToBuscador(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"buscador?param1={test}");
        }


        private void ConnectDatabase(object? sender, EventArgs e)
        {
            //todo
        }

        private async void GoToHelp(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"help?param1={test}");
        }
    }

}
