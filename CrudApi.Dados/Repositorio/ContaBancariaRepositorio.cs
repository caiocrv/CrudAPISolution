using CrudAPI.Dados.Context;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Dados.Repositorio
{
    public class ContaBancariaRepositorio : Repositorio<ContaBancaria>, IContaBancariaRepositorio
    {
        public ContaBancariaRepositorio(ContextDB db) : base(db)
        {

        }

        public async Task<ContaBancaria> ObterPorId(int id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
