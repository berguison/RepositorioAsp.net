using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinawe.ApiRest.Dominio;
using TreinaWeb.Comum.Repositorios.Entity;
using TreinaWeb.Resapi.AcessoDados.Entity.dbcontext;
namespace TreinaWeb.Apirest.Repositorio.Entity
{
    public class RepositorioAluno: RepositorioTreinaweb<Aluno,int>
    {
        public RepositorioAluno(RestapiContext dbcontext)
            :base(dbcontext)
        {

        }
    }
}
