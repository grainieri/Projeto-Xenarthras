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
    public partial class PaginaAdmin : ContentPage
    {
        public PaginaAdmin()
        {
            InitializeComponent();
        }

        private void AbrirListaAdminAparicoes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.ListaAdminAparicoes());
        }

        private void AbrirPesquisaUsuario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.PesquisaUsuario());
        }

        private void AbrirPesquisaAparicao(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Paginas.PesquisaAparicao());
        }
    }
}