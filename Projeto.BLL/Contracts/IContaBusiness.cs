using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.TransferObjects;

namespace Projeto.BLL.Contracts
{
    public interface IContaBusiness
    {
        void CadastrarConta(Conta conta);

        void AtualizarConta(Conta conta);

        void ExcluirConta(Conta conta);

        List<Conta> ConsultarContas();

        Conta ConsultarContaPorId(int id);

        List<Conta> ConsultarPorData
            (DateTime dataIni, DateTime dataFim);

        List<SomatorioContaDTO> AgruparPorCategoria
            (DateTime dataIni, DateTime dataFim);
    }
}
