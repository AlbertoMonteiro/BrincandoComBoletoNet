using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiTeste.Models;

namespace WebApiTeste.Controllers
{
    //Code First
    //Database First
    public class HomeController : ApiController
    {
        public IEnumerable<Pessoa> Get()
        {
            var ctx = new WebApiTesteContexto();
            return ctx.Pessoas.ToList();
        }
    }
}