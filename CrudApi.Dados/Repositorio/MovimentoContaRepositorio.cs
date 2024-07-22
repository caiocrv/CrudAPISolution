using CrudApi.Dados.Context;
using CrudApi.Regranegocio.Models;
using CrudApi.RegraNegocio.Interfaces;

namespace CrudApi.Dados.Repositorio
{
    public class MovimentoContaRepositorio : Repositorio<MovimentoConta>, IMovimentoContaRepositorio
    {
        public MovimentoContaRepositorio(ContextDB db) : base(db)
        {

        }
    }
}
