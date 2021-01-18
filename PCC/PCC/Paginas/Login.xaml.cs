using Newtonsoft.Json;
using PCC.AppBase;
using PCC.Model;
using PCC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private UsuarioService _service;
        public Login()
        {
            InitializeComponent();

            _service = new UsuarioService();
        }

        private void AbrirCadastro(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Paginas.Cadastro());
        }

        private void VoltarAoInicio()
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new AppBase.Menu();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private async void FazerEntrada(object sender, EventArgs e)
        {
            //Código de login
            string email = usu_Email.Text;
            string senha = usu_Senha.Text;

            ResponseService<Usuario> responseService = await _service.LoginUsuario(email, senha);

            if (responseService.IsSuccess)
            {
                App.Current.Properties.Add("Usuario", JsonConvert.SerializeObject(responseService.Data));
                await App.Current.SavePropertiesAsync();
                App.Current.MainPage = new AppBase.Menu();
            }
            else
            {
                if (responseService.StatusCode == 404)
                {
                    await DisplayAlert("Erro!", "Nenhum usuário encontrado.", "OK");
                }
                else
                {
                    await DisplayAlert("Erro!", "Ocorreu um erro inesperado, tente novamente mais tarde.", "OK");
                }
            }
        }
    }
}