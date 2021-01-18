using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InserirFoto : ContentPage
    {
        byte[] fotoArray = null;
        public InserirFoto()
        {
            InitializeComponent();

            BtnFoto.Clicked += TirarFoto;
        }

        private async void TirarFoto(object origem, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("Câmera indisponível", "Não encontramos uma câmera disponível.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg",
                PhotoSize = PhotoSize.Custom,
                CustomPhotoSize = 10 //90% do original
            });

            if (file == null)
                return;

            Imagem.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                MemoryStream ms = new MemoryStream();
                stream.CopyTo(ms);
                fotoArray = ms.ToArray();
                return stream;
            });

            Imagem.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
        }

        private void AbrirInserirLocalização(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InserirLocalização(fotoArray));
        }
    }
}