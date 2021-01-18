using PCC.Model;
using PCC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catalogo : TabbedPage
    {
        private AparicaoService _service;

        public Catalogo()
        {
            InitializeComponent();
            _service = new AparicaoService();
            ObterCatalogo();
        }

        private async void ObterCatalogo()
        {
            //TODO - Criar campo "Tipo" em aparições, definir padrão como "Em análise", fazer desse campo o definidor da espécie do animal
            string pagTamandua = "Tamanduá";
            string pagPreguica = "Preguica";
            string pagTatu = "Tatu";

            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    //Implementar pins
                    MapaTamandua.Children.Clear();
                    MapaPreguica.Children.Clear();
                    MapaTatu.Children.Clear();
                    var mapaTam = new Xamarin.Forms.Maps.Map(MapSpan.FromCenterAndRadius(new Position(-13.6599948, -60.7174052), Distance.FromKilometers(2500)));
                    var mapaPre = new Xamarin.Forms.Maps.Map(MapSpan.FromCenterAndRadius(new Position(-13.6599948, -60.7174052), Distance.FromKilometers(2500)));
                    var mapaTat = new Xamarin.Forms.Maps.Map(MapSpan.FromCenterAndRadius(new Position(-13.6599948, -60.7174052), Distance.FromKilometers(2500)));
                    MapaTamandua.Children.Add(mapaTam);
                    PesquisarAparicao(pagTamandua, mapaTam);
                    MapaPreguica.Children.Add(mapaPre);
                    PesquisarAparicao(pagPreguica, mapaPre);
                    MapaTatu.Children.Add(mapaTat);
                    PesquisarAparicao(pagTatu, mapaTat);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle not permitted on device exception
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private async void PesquisarAparicao(string tituloPagina, Xamarin.Forms.Maps.Map mapa)
        {
            ResponseService<List<Aparicao>> responseService = await _service.Mostrar20UltimasAparicoes(tituloPagina);

            if (responseService.IsSuccess)
            {
                foreach (Aparicao aparicao in responseService.Data)
                {
                    Pin pin = new Pin
                    {
                        Label = aparicao.ani_Especie,
                        Type = PinType.Place,
                        Position = new Position(aparicao.apa_Latitude, aparicao.apa_Longitude)
                    };

                    mapa.Pins.Add(pin);
                }
            }
            else
            {
                await DisplayAlert("Ops!", "Erro inesperado!", "OK");
            }
        }
    }
}