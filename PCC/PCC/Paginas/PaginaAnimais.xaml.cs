using PCC.Model;
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
    public partial class PaginaAnimais : TabbedPage
    {
        public PaginaAnimais()
        {
            InitializeComponent();
            if (clDados.SelectedItem != null)
            {
                CliqueVerAnimal();
            }
        }
        
        public void CliqueVerAnimal()
        {
            Animal animal = new Animal();
            string aniUrl = animal.ani_Url;
            Xamarin.Essentials.Browser.OpenAsync(aniUrl);
        }
    }
}