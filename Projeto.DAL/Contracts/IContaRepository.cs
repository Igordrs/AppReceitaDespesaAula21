using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.TransferObjects;

namespace Projeto.DAL.Contracts
{
    public interface IContaRepository : IBaseRepository<Conta>
    {
        List<Conta> FindAllByData
            (DateTime dataIni, DateTime dataFim);

        List<SomatorioContaDTO> GroupByCategoria
            (DateTime dataIni, DateTime dataFim);
    }
}
