using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Projeto.Entities;

namespace Projeto.Presentation.Models
{
    public class ContaCadastroViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public Categoria Categoria { get; set; }
    }
}