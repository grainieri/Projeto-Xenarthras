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
    public partial class DetalheTamandua : ContentPage
    {
        public string Nome
        {
            set
            {
                BindingContext = Tamandua.Tamanduas.FirstOrDefault(m => m.ani_Nome == Uri.UnescapeDataString(value));
            }
        }
        public DetalheTamandua()
        {
            InitializeComponent();
        }
    }
}