using Aula02_module.BLL.Facade;
using Aula02_module.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AULA02MVC.Controllers
{
    public class PessoasController : Controller
    {
        private PessoasFacade pessoasFacade;
        public PessoasController()
        {  pessoasFacade = new PessoasFacade(); }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TitleH1 = "Hello Pessoas";
            //List<Pessoa> pessoas = pessoasFacade.ListAllPessoas();
            //pessoas = pessoas.OrderBy(x => x.Nome).ToList();
            //pessoas = pessoas.OrderByDescending(x => x.Nome).ToList();
            //ViewBag.Pessoas = pessoas;
            //foreach (Pessoa p in pessoas)
            //{ 
            //    if ( p is PessoaFisica)
            //    { 
            //         PessoaFisica pf = (PessoaFisica)p;
            //         if (pf.Cpf.Equals("12345678")){ pf.Nome = "ALTEREI"; }
            //    }
            //    else if (p is PessoaJuridica)
            //    {
            //         PessoaJuridica pj = (PessoaJuridica)p;
            //         if (pj.Cnpj.Equals("58142003000133")){ pj.Nome = "Alterei"; }
            //    }
            //}

            List<PessoaFisica> allpf = pessoasFacade.GetAllDBPessoasFisicas();
            ViewBag.Fisico = allpf;
            return View();
        }

        public JsonResult List()
        {
            return Json(PessoasFacade.ListAllPessoas(),JsonRequestBehavior.AllowGet);

        }

        private JsonResult ReturnJson(List<Pessoa> pessoas)
        {
            throw new NotImplementedException();
        }
    }
}