using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebXenartras.Models
{
    public class Usuario
    {
        [Key]
        public int usu_ID { get; set; }

        [Required]
        [EmailAddress]
        public string usu_Email { get; set; }

        [Required]
        [MinLength(6)]
        public string usu_Senha { get; set; }

        [Required]
        public bool usu_Status { get; set; } //false = usuário comum, true = usuário administrador

    }
}
