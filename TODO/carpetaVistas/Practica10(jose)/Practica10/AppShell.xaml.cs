using Practica10.views;

namespace Practica10
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("mainpage", typeof(MainPage));
            Routing.RegisterRoute("buscador", typeof(BuscadorProfesores));
            Routing.RegisterRoute("help", typeof(Help));


        }
    }
}
