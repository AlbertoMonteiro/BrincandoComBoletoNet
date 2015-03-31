using WebApiTeste.Models;

namespace WebApiTeste.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiTeste.Models.WebApiTesteContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiTeste.Models.WebApiTesteContexto context)
        {
            context.Pessoas.AddOrUpdate(new Pessoa{Nome = "Silvio"});
            context.Pessoas.AddOrUpdate(new Pessoa{Nome = "Alberto"});
            context.Pessoas.AddOrUpdate(new Pessoa{Nome = "Gean"});
        }
    }
}
