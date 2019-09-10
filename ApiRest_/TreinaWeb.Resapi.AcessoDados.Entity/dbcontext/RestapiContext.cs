using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinawe.ApiRest.Dominio;

namespace TreinaWeb.Resapi.AcessoDados.Entity.dbcontext
{
    public class RestapiContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public RestapiContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
