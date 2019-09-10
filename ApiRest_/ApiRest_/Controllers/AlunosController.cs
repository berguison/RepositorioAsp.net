using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Treinawe.ApiRest.Dominio;
using TreinaWeb.Apirest.Repositorio.Entity;
using TreinaWeb.Comum.Repositorios.Interfaces;
using TreinaWeb.Resapi.AcessoDados.Entity.dbcontext;

namespace ApiRest_.Controllers
{
    public class AlunosController : ApiController
    {
        private IRepositorioTreinaWeb<Aluno, int> _repositorioAlunos = new RepositorioAluno(new RestapiContext());

        public IEnumerable<Aluno> Get()
        {
            return _repositorioAlunos.Selecionar();
        }
        public HttpResponseMessage Get(int? id)
        {
            if (!id.HasValue)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            Aluno aluno =  _repositorioAlunos.SelecionarId(id.Value);

            if (aluno==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.Found, aluno);
        }
    }
}
