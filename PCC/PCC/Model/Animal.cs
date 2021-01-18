using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xamarin.Forms;

namespace PCC.Model
{
    public class Animal
    {
        [Key]
        public int ani_ID { get; set; }
        public string ani_Nome { get; set; }
        public string ani_NomeCientifico { get; set; }
        public string ani_Especie { get; set; } //Tatu, Preguiça ou Tamanduá
        public string ani_Localizacao { get; set; } //Região que é encontrado
        public string ani_Descricao { get; set; } //Texto sobre o animal
        public string ani_UrlImagem { get; set; } 
        public string ani_Url { get; set; }
    }
}