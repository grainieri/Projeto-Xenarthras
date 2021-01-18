using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PCC.Model
{
    public class Usuario
    {
        [Key]
        public int usu_ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E002")]
        public string usu_Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E003")]
        public string usu_Senha { get; set; }

        [Required(ErrorMessageResourceType = typeof(PCC.Utility.Language.Messages), ErrorMessageResourceName = "MSG_E001")]
        public bool usu_Status { get; set; } //false = usuário comum, true = usuário administrador

    }
}
