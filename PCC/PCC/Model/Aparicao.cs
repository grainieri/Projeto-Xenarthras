using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCC.Model
{
    public class Aparicao
    {
        [Key]
        public int apa_ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public byte[] apa_IMG { get; set; } //Foto do animal

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public double apa_Latitude { get; set; }

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public double apa_Longitude { get; set; }

        public string apa_Comentario { get; set; } //Comentário deixado (ou não) na inserção da aparição

        public DateTime apa_Data { get; set; } //Data em que a aparição foi cadastrada, definida automaticamente na criação

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public string apa_Status{ get; set; } //Em análise, Reprovado e Aprovado

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public int usu_ID { get; set; }

        [ForeignKey("usu_ID")]
        public Usuario Usuario { get; set; }

        public string ani_Especie { get; set; } //Tamanduá, Bicho Preguiça ou Tatu, é usado no método Mostrar20UltimasAparicoes do AparicaoController
    }
}
