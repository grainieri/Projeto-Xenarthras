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
    public partial class InserirMaisDetalhes : ContentPage
    {
        private AparicaoService _service;
        byte[] fotoArray = null;
        double latitude;
        double longitude;
        string comentario;
        int id;

        public InserirMaisDetalhes(byte[] fotoArray, double latitude, double longitude)
        {
            InitializeComponent();
            _service = new AparicaoService();

            this.fotoArray = fotoArray;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        private async void EnviarDados(object sender, EventArgs e)
        {
            comentario = txtComentario.Text;
            DateTime data = DateTime.Now;

            TxtMensagens.Text = String.Empty;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(App.Current.Properties["Usuario"].ToString());

            Aparicao aparicao = new Aparicao()
            {
                apa_IMG = fotoArray,
                apa_Latitude = latitude,
                apa_Longitude = longitude,
                apa_Comentario = comentario,
                apa_Data = data,
                apa_Status = "Em análise",
                usu_ID = usuario.usu_ID,
                ani_Especie = "Em análise"
            };

            ResponseService<Aparicao> responseService = await _service.CadastrarAparicao(aparicao);

            if (responseService.IsSuccess)
            {
                await DisplayAlert("Aparição cadastrada!", "Aparição cadastrada com sucesso!", "OK");

                VoltarAoInicio();
            }
            else
            {
                if (responseService.StatusCode == 404)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var dic in responseService.Errors)
                    {
                        foreach (var mensagem in dic.Value)
                        {
                            sb.AppendLine(mensagem);
                        }
                    }

                    TxtMensagens.Text = sb.ToString();
                }
                else
                {
                    await DisplayAlert("Erro!", "Ocorreu um erro inesperado, tente novamente mais tarde.", "OK");
                }
                VoltarAoInicio();
            }
        }

        private void VoltarAoInicio()
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new AppBase.Menu();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}