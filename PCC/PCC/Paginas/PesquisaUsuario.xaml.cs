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
    public partial class PesquisaUsuario : ContentPage
    {
        private UsuarioService _service;
        private ObservableCollection<Usuario> _listaUsuario;
        private int _contadorPagina;

        public PesquisaUsuario()
        {
            InitializeComponent();
            _service = new UsuarioService();
        }

        private async void PesquisarUsuario(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            ResponseService<List<Usuario>> responseService = await _service.PesquisarUsuario(email, 1);

            if (responseService.IsSuccess)
            {
                //Colocar dentro da Collection View
                _listaUsuario = new ObservableCollection<Usuario>(responseService.Data);
                ListaUsuario.ItemsSource = responseService.Data;
                _contadorPagina = 1;
                ListaUsuario.RemainingItemsThreshold = 1;
            }
            else
            {
                await DisplayAlert("Ops!", "Erro inesperado!", "OK");
            }
        }

        private async void InfinitySearch(object sender, EventArgs e)
        {
            _contadorPagina++;

            string email = txtEmail.Text;
            ResponseService<List<Usuario>> responseService = await _service.PesquisarUsuario(email, _contadorPagina);

            if (responseService.IsSuccess)
            {
                //Colocar dentro da Collection View
                var listaAparicaoServico = responseService.Data;
                foreach (var item in listaAparicaoServico)
                {
                    _listaUsuario.Add(item);
                }
            }
            else
            {
                await DisplayAlert("Ops!", "Erro inesperado!", "OK");
            }
        }
    }
}