using Colibri.Views; // Importa las vistas

namespace Colibri
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SignUp(); // Nombre correcto
        }
    }
}
