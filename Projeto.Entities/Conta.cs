using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Conta
    {
        public int IdConta { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        //Relacionamento -> Conta TEM 1 Categoria
        public Categoria Categoria { get; set; }
    }
}
