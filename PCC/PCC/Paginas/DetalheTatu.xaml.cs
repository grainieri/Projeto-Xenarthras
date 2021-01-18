using PCC.Dados;
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
    public partial class DetalheTatu : ContentPage
    {
        public string Nome
        {
            set
            {
                BindingContext = Tatu.Tatus.FirstOrDefault(m => m.ani_Nome == Uri.UnescapeDataString(value));
            }
        }
        public DetalheTatu()
        {
            InitializeComponent();
        }
    }
}