using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoletoNet;

namespace WebApiTeste.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            var cedente = new Cedente("03318802379", "Alberto Monteir", "3653", "311456");
            cedente.Convenio = 123456;
            var boleto = new Boleto(DateTime.Now, 1, "17-019", "18024", cedente)
            {
                NumeroDocumento = "18024",
                Sacado = new Sacado("03318802379", "Alberto Monteiro")
            };
            boleto.Sacado.Instrucoes.Add(new Instrucao_BancoBrasil(9, 5));
            var boletoBancario = new BoletoBancario
            {
                CodigoBanco = 1,
                Boleto = boleto
            };
            boleto.Valida();

            var fileName = Server.MapPath("~/Content/Boletos/");
            boletoBancario.ResolveClientUrl(Server.MapPath("~/"));
            boletoBancario.ResolveUrl(Server.MapPath("~/"));
            return Content(boletoBancario.MontaHtml(fileName, ""));
        }
    }
}