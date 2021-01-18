using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Markup;
namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InserirLocalização : ContentPage
    {
        MapSpan mapSpanCentro;
        byte[] fotoArray = null;
        double latitude;
        double longitude;
        Image pinMeio = new Image();

        public InserirLocalização(byte[] fotoArray)
        {
            InitializeComponent();
            this.fotoArray = fotoArray;
            //BtnLocal.Clicked += ObterLocalizacao;
            //Definindo Pin no centro do Mapa
            int tamanhoPin = 35;
            pinMeio.Source = "ic_pin.png";
            pinMeio.VerticalOptions = LayoutOptions.CenterAndExpand;
            pinMeio.WidthRequest = tamanhoPin;
            pinMeio.HeightRequest = tamanhoPin;
            GerarMapa();
        }

        async void GerarMapa()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    GridMapa.Children.Clear();
                    var mapaMapSpan = MapSpan.FromCenterAndRadius(new Position(location.Latitude, location.Longitude), Distance.FromKilometers(0.5));
                    mapSpanCentro = mapaMapSpan;
                    var mapaAtual = new Xamarin.Forms.Maps.Map(mapaMapSpan);
                    GridMapa.Children.Add(mapaAtual);
                    GridMapa.Children.Add(pinMeio);
                    location = null;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Erro :(", "A função de localização no dispositivo não é suportada.", "OK");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Erro :(", "A função de localização no dispositivo não está ativa.", "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Erro :(", "Sem as permissões necessárias para obter a localização.", "OK");
            }
            catch (Exception ex)
            {
                //Outros erros
            }
        }

        private Position PegarPosiçãoCentro()
        {
            //TODO - PEGAR LOCALIZAÇÃO PELO CENTRO
            latitude = mapSpanCentro.Center.Latitude;
            longitude = mapSpanCentro.Center.Longitude;
            Position posicao = new Position(latitude, longitude);

            return posicao;
        }


        private void AbrirInserirDetalhes(object sender, EventArgs e)
        {
            Position posicao = PegarPosiçãoCentro();
            Navigation.PushAsync(new InserirMaisDetalhes(fotoArray, posicao.Latitude, posicao.Longitude));
        }
    }
}