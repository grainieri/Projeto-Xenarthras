using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();

            if (App.Current.Properties.ContainsKey("Usuario"))
            {
                btnLogin.IsEnabled = false;
                btnLogin.Text = "Logado";
                btnCadastro.IsVisible = false;
            }
            else
            {
                btnMeusEnvios.IsVisible = false;
                btnAdministrar.IsVisible = false;
                btnEnviarDados.IsVisible = false;
            }
        }

        private void VoltarAoInicio(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new AppBase.Menu();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirInserirDados(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.InserirFoto());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCatalogo(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.Catalogo());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLogin(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.Login());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAnimais(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.PaginaAnimais());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMeusEnvios(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.MeusEnvios());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCadastro(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.Cadastro());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
        private void AbrirAdmin(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new Paginas.PaginaAdmin());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}