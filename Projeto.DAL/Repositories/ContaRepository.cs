using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.Context;
using Projeto.DAL.Contracts;
using Projeto.Entities;
using Projeto.TransferObjects;

namespace Projeto.DAL.Repositories
{
    public class ContaRepository
        : BaseRepository<Conta>, IContaRepository
    {
        public List<Conta> FindAllByData(DateTime dataIni, DateTime dataFim)
        {
            using (DataContext con = new DataContext())
            {
                return con.Conta
                        .Where(c => c.Data >= dataIni && c.Data <= dataFim)
                        .OrderByDescending(c => c.Data)
                        .ToList();
            }
        }

        public List<SomatorioContaDTO> GroupByCategoria(DateTime dataIni, DateTime dataFim)
        {
            using (DataContext con = new DataContext())
            {
                return con.Conta
                        .Where(c => c.Data >= dataIni && c.Data <= dataFim)
                        .GroupBy(c => c.Categoria)
                        .Select(
                            g => new SomatorioContaDTO
                            {
                                Categoria = g.Key.ToString(),
                                Somatorio = g.Sum(c => c.Valor)
                            }
                        ).ToList();
            }
        }
    }
}
