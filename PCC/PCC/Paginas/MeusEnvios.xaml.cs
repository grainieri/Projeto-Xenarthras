using Newtonsoft.Json;
using PCC.Model;
using PCC.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeusEnvios : ContentPage
    {
        private AparicaoService _service;
        private ObservableCollection<Aparicao> _listaAparicao;
        private int _contadorPagina;
        public MeusEnvios()
        {
            InitializeComponent();
            _service = new AparicaoService();
            PesquisarAparicao();
        }

        private async void PesquisarAparicao()
        {
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(App.Current.Properties["Usuario"].ToString());

            ResponseService<List<Aparicao>> responseService = await _service.MostrarAparicoes(usuario.usu_ID, 1);

            if (responseService.IsSuccess)
            {
                //Colocar dentro da Collection View
                _listaAparicao = new ObservableCollection<Aparicao>(responseService.Data);
                ListaAparicao.ItemsSource = responseService.Data;
                _contadorPagina = 1;
                ListaAparicao.RemainingItemsThreshold = 1;

            }
            else
            {
                await DisplayAlert("Ops!", "Erro inesperado!", "OK");
            }
        }
        private async void InfinitySearch(object sender, EventArgs e)
        {
            _contadorPagina++;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(App.Current.Properties["Usuario"].ToString());

            ResponseService<List<Aparicao>> responseService = await _service.MostrarAparicoes(usuario.usu_ID, _contadorPagina);

            if (responseService.IsSuccess)
            {
                //Colocar dentro da Collection View
                var listaAparicaoServico = responseService.Data;
                foreach (var item in listaAparicaoServico)
                {
                    _listaAparicao.Add(item);
                }
            }
            else
            {
                await DisplayAlert("Ops!", "Erro inesperado!", "OK");
            }
        }
    }
}