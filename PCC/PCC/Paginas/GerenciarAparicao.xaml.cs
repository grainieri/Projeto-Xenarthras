using Newtonsoft.Json;
using PCC.Model;
using PCC.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace PCC.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GerenciarAparicao : ContentPage
    {
        private AparicaoService _service;
        public GerenciarAparicao()
        {
            InitializeComponent();

            _service = new AparicaoService();

            var listaPreguica = new List<string>
                {
                      "Preguiça-Anã (Bradypus pygmaeus)" ,
                      "Preguiça-De-Coleira ou Preguiça-Do-Norte (Bradypus torquatus)" ,
                      "Preguiça-De-Bentinho (Bradypus tridactylus)" ,
                      "Preguiça-De-Bentinho ou Preguiça-De-Óculos  (Bradypus variegatus)" ,
                      "Preguiça De-Dois-Dedos (Choloepus didactylus)" ,
                      "Preguiça-Real (Choloepus hoffmanni)"
                };
            var listaTamandua = new List<string>
                {
                      "Tamanduaí da Bolívia (Cyclopes catellus)" ,
                      "Tamanduaí (Cyclopes didactylus)" ,
                      "Tamanduaí da América Central (Cyclopes dorsalis)" ,
                      "Tamanduaí do Rio Negro (Cyclopes ida)" ,
                      "Tamanduaí Vermelho (Cyclopes rufus)" ,
                      "Tamanduaí de Thomas (Cyclopes thomasi)" ,
                      "Tamanduaí do Xingu (Cyclopes xinguensis)" ,
                      "Tamanduá-Bandeira (Myrmecophaga tridactyla)" ,
                      "Tamanduá do Norte (Tamandua mexicana)" ,
                      "Tamanduá-mirim (Tamandua tetradactyla)" 
                };
            var listaTatu = new List<string>
                {
                      "Tatu-de-Rabo-Mole da Centroamérica (Cabassous centralis)",
                      "Tatu-de-Rabo-Mole do Chaco (Cabassous chacoensis)" ,
                      "Tatu-de-Rabo-Mole-Grande (Cabassous tatouay)" ,
                      "Tatu-de-Rabo-Mole-Pequeno (Cabassous unicinctus)" ,
                      "Pichiciego Maior (Calyptophractus retusus)" ,
                      "Tatu-Chorão (Chaetophractus vellerosus)" ,
                      "Tatu-Peludo (Chaetophractus villosus)" ,
                      "Pichi Cego (Chlamyphorus truncatus)" ,
                      "Tatu-Quinze-Quilos (Dasypus beniensis)" ,
                      "Tatuíra (Dasypus hybridus)" ,
                      "Tatu-Quinze-Quilos (Dasypus kappleri)" ,
                      "Tatu-de-Mazza (Dasypus mazzai)" ,
                      "Tatu-Galinha (Dasypus novemcinctus)" ,
                      "Tatu-Quinze-Quilos (Dasypus pastasae)" ,
                      "Tatu-Peludo (Dasypus pilosus)" ,
                      "Tatu-das-Savanas (Dasypus sabanicola)" ,
                      "Tatu-í (Dasypus septemcinctus)" ,
                      "Tatu-Peba (Euphractus sexcinctus)" ,
                      "Tatu-Canastra (Priodontes maximus)" ,
                      "Tatu-bola (Tolypeutes matacus)" ,
                      "Tatu-bola (Tolypeutes tricinctus)" ,
                      "Piche (Zaedyus pichiy)" 
                };

            Picker1.SelectedIndexChanged += (sender, args) =>
            {

                if (Picker1.SelectedIndex == -1)
                {
                    
                }
                else if (Picker1.SelectedIndex == 0)
                {
                    Picker2.ItemsSource = listaPreguica;
                }
                else if (Picker1.SelectedIndex == 1)
                {
                    Picker2.ItemsSource = listaTatu;
                }
                else
                {
                    Picker2.ItemsSource = listaTamandua;
                }
            };
        }


        private void AprovarAparicao(object sender, EventArgs e)
        {
            Aparicao aparicao = ((Aparicao)BindingContext);
            int apa_ID = aparicao.apa_ID;
            string apa_Status = "Aprovado";
            string ani_Especie = Picker2.SelectedIndex.ToString();
            if (Picker1.SelectedIndex == 0)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Preguiça-Anã (Bradypus pygmaeus)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Preguiça-De-Coleira ou Preguiça-Do-Norte (Bradypus torquatus)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Preguiça-De-Bentinho (Bradypus tridactylus)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Preguiça-De-Bentinho ou Preguiça-De-Óculos  (Bradypus variegatus)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Preguiça De-Dois-Dedos (Choloepus didactylus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Preguiça-Real (Choloepus hoffmanni)";
                }
            }
            else if (Picker1.SelectedIndex == 1)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole da Centroamérica (Cabassous centralis)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole do Chaco (Cabassous chacoensis)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole-Grande (Cabassous tatouay)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole-Pequeno (Cabassous unicinctus)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Pichiciego Maior (Calyptophractus retusus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Tatu-Chorão (Chaetophractus vellerosus)";
                }
                else if (ani_Especie == "6")
                {
                    ani_Especie = "Tatu-Peludo (Chaetophractus villosus)";
                }
                else if (ani_Especie == "7")
                {
                    ani_Especie = "Pichi Cego (Chlamyphorus truncatus)";
                }
                else if (ani_Especie == "8")
                {
                    ani_Especie = "Tatu-Quinze-Quilos(Dasypus beniensis)" ;
                }
                else if (ani_Especie == "9")
                {
                    ani_Especie = "Tatuíra (Dasypus hybridus)";
                }
                else if (ani_Especie == "10")
                {
                    ani_Especie = "Tatu-Quinze-Quilos (Dasypus kappleri)";
                }
                else if (ani_Especie == "11")
                {
                    ani_Especie = "Tatu-de-Mazza (Dasypus mazzai)";
                }
                else if (ani_Especie == "12")
                {
                    ani_Especie = "Tatu-Galinha (Dasypus novemcinctus)";
                }
                else if (ani_Especie == "13")
                {
                    ani_Especie = "Tatu-Quinze-Quilos (Dasypus pastasae)";
                }
                else if (ani_Especie == "14")
                {
                    ani_Especie = "Tatu-Peludo (Dasypus pilosus)";
                }
                else if (ani_Especie == "15")
                {
                    ani_Especie = "Tatu-das-Savanas (Dasypus sabanicola)";
                }
                else if (ani_Especie == "16")
                {
                    ani_Especie = "Tatu-í (Dasypus septemcinctus)";
                }
                else if (ani_Especie == "17")
                {
                    ani_Especie = "Tatu-Peba (Euphractus sexcinctus)";
                }
                else if (ani_Especie == "18")
                {
                    ani_Especie = "Tatu-Canastra (Priodontes maximus)";
                }
                else if (ani_Especie == "19")
                {
                    ani_Especie = "Tatu-bola (Tolypeutes matacus)";
                }
                else if (ani_Especie == "20")
                {
                    ani_Especie = "Tatu-bola (Tolypeutes tricinctus)";
                }
                else if (ani_Especie == "14")
                {
                    ani_Especie = "Piche (Zaedyus pichiy)";
                }
            }
            else if (Picker1.SelectedIndex == 2)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Tamanduaí da Bolívia (Cyclopes catellus)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Tamanduaí (Cyclopes didactylus)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Tamanduaí da América Central (Cyclopes dorsalis)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Tamanduaí do Rio Negro (Cyclopes ida)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Tamanduaí Vermelho (Cyclopes rufus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Tamanduaí de Thomas (Cyclopes thomasi)";
                }
                else if (ani_Especie == "6")
                {
                    ani_Especie = "Tamanduaí do Xingu (Cyclopes xinguensis)";
                }
                else if (ani_Especie == "7")
                {
                    ani_Especie = "Tamanduá-Bandeira (Myrmecophaga tridactyla)";
                }
                else if (ani_Especie == "8")
                {
                    ani_Especie = "Tamanduá do Norte (Tamandua mexicana)";
                }
                else if (ani_Especie == "9")
                {
                    ani_Especie = "Tamanduá-mirim (Tamandua tetradactyla)";
                }
            }

            string apa_Comentario = edtComentario.Text;
            AtualizarAparicao(aparicao, apa_Status, ani_Especie, apa_ID, apa_Comentario);
        }

        private void ReprovarAparicao(object sender, EventArgs e)
        {
            Aparicao aparicao = ((Aparicao)BindingContext);
            int apa_ID = aparicao.apa_ID;
            string apa_Status = "Reprovado";
            string ani_Especie = Picker2.SelectedIndex.ToString();
            if (Picker1.SelectedIndex == 0)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Preguiça-Anã (Bradypus pygmaeus)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Preguiça-De-Coleira ou Preguiça-Do-Norte (Bradypus torquatus)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Preguiça-De-Bentinho (Bradypus tridactylus)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Preguiça-De-Bentinho ou Preguiça-De-Óculos  (Bradypus variegatus)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Preguiça De-Dois-Dedos (Choloepus didactylus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Preguiça-Real (Choloepus hoffmanni)";
                }
            }
            else if (Picker1.SelectedIndex == 1)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole da Centroamérica (Cabassous centralis)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole do Chaco (Cabassous chacoensis)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole-Grande (Cabassous tatouay)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Tatu-de-Rabo-Mole-Pequeno (Cabassous unicinctus)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Pichiciego Maior (Calyptophractus retusus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Tatu-Chorão (Chaetophractus vellerosus)";
                }
                else if (ani_Especie == "6")
                {
                    ani_Especie = "Tatu-Peludo (Chaetophractus villosus)";
                }
                else if (ani_Especie == "7")
                {
                    ani_Especie = "Pichi Cego (Chlamyphorus truncatus)";
                }
                else if (ani_Especie == "8")
                {
                    ani_Especie = "Tatu-Quinze-Quilos(Dasypus beniensis)";
                }
                else if (ani_Especie == "9")
                {
                    ani_Especie = "Tatuíra (Dasypus hybridus)";
                }
                else if (ani_Especie == "10")
                {
                    ani_Especie = "Tatu-Quinze-Quilos (Dasypus kappleri)";
                }
                else if (ani_Especie == "11")
                {
                    ani_Especie = "Tatu-de-Mazza (Dasypus mazzai)";
                }
                else if (ani_Especie == "12")
                {
                    ani_Especie = "Tatu-Galinha (Dasypus novemcinctus)";
                }
                else if (ani_Especie == "13")
                {
                    ani_Especie = "Tatu-Quinze-Quilos (Dasypus pastasae)";
                }
                else if (ani_Especie == "14")
                {
                    ani_Especie = "Tatu-Peludo (Dasypus pilosus)";
                }
                else if (ani_Especie == "15")
                {
                    ani_Especie = "Tatu-das-Savanas (Dasypus sabanicola)";
                }
                else if (ani_Especie == "16")
                {
                    ani_Especie = "Tatu-í (Dasypus septemcinctus)";
                }
                else if (ani_Especie == "17")
                {
                    ani_Especie = "Tatu-Peba (Euphractus sexcinctus)";
                }
                else if (ani_Especie == "18")
                {
                    ani_Especie = "Tatu-Canastra (Priodontes maximus)";
                }
                else if (ani_Especie == "19")
                {
                    ani_Especie = "Tatu-bola (Tolypeutes matacus)";
                }
                else if (ani_Especie == "20")
                {
                    ani_Especie = "Tatu-bola (Tolypeutes tricinctus)";
                }
                else if (ani_Especie == "14")
                {
                    ani_Especie = "Piche (Zaedyus pichiy)";
                }
            }
            else if (Picker1.SelectedIndex == 2)
            {
                if (ani_Especie == "0")
                {
                    ani_Especie = "Tamanduaí da Bolívia (Cyclopes catellus)";
                }
                else if (ani_Especie == "1")
                {
                    ani_Especie = "Tamanduaí (Cyclopes didactylus)";
                }
                else if (ani_Especie == "2")
                {
                    ani_Especie = "Tamanduaí da América Central (Cyclopes dorsalis)";
                }
                else if (ani_Especie == "3")
                {
                    ani_Especie = "Tamanduaí do Rio Negro (Cyclopes ida)";
                }
                else if (ani_Especie == "4")
                {
                    ani_Especie = "Tamanduaí Vermelho (Cyclopes rufus)";
                }
                else if (ani_Especie == "5")
                {
                    ani_Especie = "Tamanduaí de Thomas (Cyclopes thomasi)";
                }
                else if (ani_Especie == "6")
                {
                    ani_Especie = "Tamanduaí do Xingu (Cyclopes xinguensis)";
                }
                else if (ani_Especie == "7")
                {
                    ani_Especie = "Tamanduá-Bandeira (Myrmecophaga tridactyla)";
                }
                else if (ani_Especie == "8")
                {
                    ani_Especie = "Tamanduá do Norte (Tamandua mexicana)";
                }
                else if (ani_Especie == "9")
                {
                    ani_Especie = "Tamanduá-mirim (Tamandua tetradactyla)";
                }
            }

            string apa_Comentario = edtComentario.Text;
            AtualizarAparicao(aparicao, apa_Status, ani_Especie, apa_ID, apa_Comentario);
        }

        private async void AtualizarAparicao(Aparicao aparicao, string apa_Status, string ani_Especie, int apa_ID, string apa_Comentario)
        {
            //TODO - verificar se esse método funciona

            aparicao.apa_Status = apa_Status;
            aparicao.apa_ID = apa_ID;
            aparicao.ani_Especie = ani_Especie;
            aparicao.apa_Comentario = apa_Comentario;
            
            ResponseService<Aparicao> responseService = await _service.AtualizarAparicao(aparicao);

            if (responseService.IsSuccess)
            {
                await DisplayAlert("Aparição atualizada!", "Aparição atualizada com sucesso!", "OK");

                App.Current.MainPage = new NavigationPage(new AppBase.Menu());
            }
            else
            {
                if (responseService.StatusCode == 404)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var dic in responseService.Errors)
                    {
                        foreach (var mensagem in dic.Value)
                        {
                            sb.AppendLine(mensagem);
                        }
                    }

                    sb.ToString();
                }
                else
                {
                    await DisplayAlert("Erro!", "Ocorreu um erro inesperado, tente novamente mais tarde.", "OK");
                }
            }
        }

        private void MostrarFoto(object sender, EventArgs e)
        {
            //Pegar foto do binding context, converter e exibir
            Aparicao aparicao = ((Aparicao)BindingContext);

            //Converter Imagem
            Image image = new Image();
            Stream stream = new MemoryStream(aparicao.apa_IMG);

            //Abrir Imagem em nova tela

            Navigation.PushAsync(new VerFoto(new MemoryStream(aparicao.apa_IMG)));
        }

        private void MostrarMapa(object sender, EventArgs e)
        {
            Aparicao aparicao = ((Aparicao)BindingContext);
            GridMapa.Children.Clear();
            var mapaMapSpan = MapSpan.FromCenterAndRadius(new Position(aparicao.apa_Latitude, aparicao.apa_Longitude), Distance.FromKilometers(0.5));
            var mapaAtual = new Xamarin.Forms.Maps.Map(mapaMapSpan);
            GridMapa.Children.Add(mapaAtual);
        }

    }
}
