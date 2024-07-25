using CrudAPI.Dados.Context;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;

namespace CrudAPI.Dados.Repositorio
{
    public class MovimentoContaRepositorio : Repositorio<MovimentoConta>, IMovimentoContaRepositorio
    {
        public MovimentoContaRepositorio(ContextDB db) : base(db)
        {
        }
    }
}
