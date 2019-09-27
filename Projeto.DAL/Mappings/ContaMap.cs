using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.DAL.Mappings
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        //construtor -> ctor + 2x[tab]
        public ContaMap()
        {
            //nome da tabela
            ToTable("CONTA");

            //chave primária
            HasKey(c => c.IdConta);

            //mapear todos os campos
            Property(c => c.IdConta)
                .HasColumnName("IDCONTA");

            Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Valor)
                .HasColumnName("VALOR")
                .HasPrecision(18,2)
                .IsRequired();

            Property(c => c.Data)
               .HasColumnName("DATA")
               .IsRequired();

            Property(c => c.Categoria)
               .HasColumnName("CATEGORIA")
               .IsRequired();
        }
    }
}
