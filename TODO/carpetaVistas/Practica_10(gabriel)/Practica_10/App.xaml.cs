namespace Practica_10;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());

        window.MinimumWidth = 1359; // Tamaño mínimo de la ventana
        window.MinimumHeight = 699; // Tamaño mínimo de la ventana
        window.MaximumWidth = 1360; // Tamaño máximo de la ventana
        window.MaximumHeight = 700; // Tamaño máximo de la ventana

        return window;
    }
}