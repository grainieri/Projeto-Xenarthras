using Newtonsoft.Json;
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
    public partial class Cadastro : ContentPage
    {
        private UsuarioService _service;
        public Cadastro()
        {
            InitializeComponent();

            _service = new UsuarioService();
        }

        private async void FazerCadastro(object sender, EventArgs e)
        {
            TxtMensagens.Text = String.Empty;
            string email = txtEmail.Text;
            string senha1 = txtSenha1.Text;
            string senha2 = txtSenha2.Text;
            if (senha1 != senha2)
            {
                await DisplayAlert("Erro","Senhas não coicidem","OK");
                txtSenha1.Text = "";
                txtSenha2.Text = "";
            }
            else
            {
                string senha = senha1;
                Usuario usuario = new Usuario() { usu_Email = email, usu_Senha = senha, usu_Status = false } ;
                ResponseService<Usuario> responseService = await _service.CadastrarUsuario(usuario);

                if (responseService.IsSuccess)
                {
                    App.Current.Properties.Add("Usuario", JsonConvert.SerializeObject(responseService.Data));
                    await App.Current.SavePropertiesAsync();

                    VoltarAoInicio();
                }
                else
                {
                    if (responseService.StatusCode == 404)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (var dic in responseService.Errors)
                        {
                            foreach(var mensagem in dic.Value)
                            {
                                sb.AppendLine(mensagem);
                            }
                        }
                        TxtMensagens.Text = sb.ToString();
                        await DisplayAlert("Erro!", "Nenhum usuário encontrado.", "OK");
                    }
                }

                await DisplayAlert("Pronto!", "Cadastro realizado com sucesso", "OK");
                VoltarAoInicio();
            }
        }

        private void VoltarAoInicio()
        {
            App.Current.MainPage = new AppBase.Menu();
        }
    }
}