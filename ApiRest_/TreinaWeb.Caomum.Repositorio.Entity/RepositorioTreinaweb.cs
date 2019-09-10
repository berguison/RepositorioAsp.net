using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Caomum;
using TreinaWeb.Comum.Repositorios.Interfaces;

namespace TreinaWeb.Comum.Repositorios.Entity
{
    public class RepositorioTreinaweb<TDominio, TChave> : IRepositorioTreinaWeb<TDominio, TChave>
        where TDominio : class
    {
        protected DbContext _contexto;
        public RepositorioTreinaweb(DbContext db_context)
        {
            _contexto = db_context;
        }
        public void Atualizar(TDominio dominio)
        {
            _contexto.Entry(dominio).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TDominio dominio)
        {
            _contexto.Entry(dominio).State=EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirId(TChave id)
        {
            TDominio dominio = SelecionarId(id);
            Excluir(dominio);
        }

        public void Inserir(TDominio dominio)
        {
            _contexto.Set<TDominio>().Add(dominio);
            _contexto.SaveChanges();
        }

        public List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null)
        {
            DbSet<TDominio> dbset = _contexto.Set<TDominio>();
            if (where == null)
            {
                return dbset.ToList();
            }
            else
            {
                return dbset.Where(where).ToList();
            }
        }

        public TDominio SelecionarId(TChave id)
        {
            return _contexto.Set<TDominio>().Find(id);
        }
    }
}
