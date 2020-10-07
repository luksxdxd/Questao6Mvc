using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProva6.Models
{
    public class AlunoModel
    {
        [Display(Name = "ID:")]
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Digite o nome")]
        public String Nome { get; set; }

        [Display(Name = "Endereço")]
        public String Endereco { get; set; }

        [Display(Name = "Filiação:")]
        [Required(ErrorMessage = "Informe a filiação")]
        public String Filiacao { get; set; }

        [Display(Name = "Curso:")]
        [Required(ErrorMessage = "Informe o Curso")]
        public String Curso { get; set; }

        [Display(Name = "Telefone:")]
        public int Telefone { get; set; }

        [Display(Name ="E-mail:")]
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        public String Email { get; set; }

    }
}