using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Contracts;
using Projeto.BLL.Contracts;
using Projeto.Entities;
using Projeto.TransferObjects;

namespace Projeto.BLL.Business
{
    public class ContaBusiness : IContaBusiness
    {
        //atributo
        private IContaRepository repository;

        //construtor para injeção de dependencia
        public ContaBusiness(IContaRepository repository)
        {
            this.repository = repository;
        }

        public void CadastrarConta(Conta conta)
        {
            repository.Insert(conta);
        }

        public void AtualizarConta(Conta conta)
        {
            repository.Update(conta);
        }

        public void ExcluirConta(Conta conta)
        {
            repository.Delete(conta);
        }

        public List<Conta> ConsultarContas()
        {
            return repository.FindAll();
        }

        public Conta ConsultarContaPorId(int id)
        {
            return repository.FindById(id);
        }

        public List<Conta> ConsultarPorData
            (DateTime dataIni, DateTime dataFim)
        {
            return repository.FindAllByData(dataIni, dataFim);
        }

        public List<SomatorioContaDTO> AgruparPorCategoria
            (DateTime dataIni, DateTime dataFim)
        {
            return repository.GroupByCategoria(dataIni, dataFim);
        }
    }

}
