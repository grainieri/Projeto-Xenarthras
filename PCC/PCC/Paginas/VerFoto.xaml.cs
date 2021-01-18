using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerFoto : ContentPage
    {
        public VerFoto(MemoryStream stream)
        {
            InitializeComponent();
            imgImagem.Source = ImageSource.FromStream(() => { return stream; });
        }
    }
}