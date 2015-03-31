using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiTeste.Models
{
    public class WebApiTesteContexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }

    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
    }
}