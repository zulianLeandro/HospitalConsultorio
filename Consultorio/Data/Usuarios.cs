using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Data
{
    public class Usuarios
    {
        public string Id { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "User é obrigatório!")]
        public string User { get; set; }

        [Required(ErrorMessage = "Password é obrigatório!")]
        public string Password { get; set; }

       
        public string CPF { get; set; }

        [Phone(ErrorMessage ="Cel Inválido")]
        public string CEL { get; set; }

        public string Endereco { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório!")]
        public string Tipo { get; set; }
       
 
    }
}
