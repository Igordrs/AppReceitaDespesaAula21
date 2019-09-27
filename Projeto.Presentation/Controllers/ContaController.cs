using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.BLL.Contracts;
using Projeto.Entities;
using Projeto.Presentation.Models;
using AutoMapper;
using Projeto.TransferObjects;

namespace Projeto.Presentation.Controllers
{
    public class ContaController : Controller
    {
        //atributo
        private IContaBusiness business;

        //construtor para injeção de dependencia
        public ContaController(IContaBusiness business)
        {
            this.business = business;
        }

        // GET: Conta/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Conta/Consulta
        public ActionResult Consulta()
        {
            return View();
        }

        [HttpPost] //recebe o SUBMIT do formulário de cadastro
        public ActionResult Cadastro(ContaCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Conta conta = Mapper.Map<Conta>(model);
                    business.CadastrarConta(conta);

                    ModelState.Clear(); //limpar os campos do formulário
                    ViewBag.Mensagem = $"Conta: {conta.Nome}, cadastrado com sucesso.";
                }
                catch(Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View();
        }


        public JsonResult ConsultarContas(DateTime dataIni, DateTime dataFim)
        {
            try
            {
                //executar a consulta na camada de negócio..
                List<SomatorioContaDTO> lista =
                    business.AgruparPorCategoria(dataIni, dataFim);

                //transferir para uma lista da classe viewmodel
                List<PieChartViewModel> model = Mapper
                    .Map<List<PieChartViewModel>>(lista);

                //retornando..
                return Json(model);
            }
            catch(Exception e)
            {
                //retornar mensagem de erro..
                return Json(e.Message);
            }
        }

    }
}