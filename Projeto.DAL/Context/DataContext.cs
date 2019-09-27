using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //importando
using Projeto.DAL.Mappings; //importando
using Projeto.Entities; //importando
using System.Configuration; //importando

namespace Projeto.DAL.Context
{
    //REGRA 1) Classe de contexto deverá HERDAR DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) Criar um construtor que envie para o construtor
        //da superclasse (DbContext) o caminho da connectionstring
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["aula20"].ConnectionString)
        {

        }

        //REGRA 3) Sobrescrever o método 'OnModelCreating'
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento
            modelBuilder.Configurations.Add(new ContaMap());
        }

        //REGRA 4) Declarar uma propriedade DbSet para cada entidade mapeada
        public DbSet<Conta> Conta { get; set; } //consultas LAMBDA
    }
}
