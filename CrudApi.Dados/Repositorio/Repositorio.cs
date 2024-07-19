using CrudApi.Dados.Context;
using CrudApi.Regranegocio.Models;
using CrudApi.RegraNegocio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CrudApi.Dados.Repositorio
{
    public class Repositorio<TEntidadeBase> : IRepositorio<TEntidadeBase> where TEntidadeBase : EntidadeBase, new()
    {
        protected readonly ContextDB Db;
        protected readonly DbSet<TEntidadeBase> DbSet;

        protected Repositorio(ContextDB db)
        {
            Db = db;
            DbSet = db.Set<TEntidadeBase>();
        }


        public async Task Adicionar(TEntidadeBase entidade)
        {
            DbSet.Add(entidade);
            await SaveChanges();
        }

        public async Task Atualizar(TEntidadeBase entidade)
        {
            DbSet.Update(entidade);
            await SaveChanges();
        }

        public Task<IEnumerable<TEntidadeBase>> Buscar(Expression<Func<TEntidadeBase, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public Task<List<TEntidadeBase>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Remover(TEntidadeBase entidade)
        {
            DbSet.Remove(entidade);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
