using CrudApi.Dados.Context;
using CrudApi.Regranegocio.Models;
using CrudApi.RegraNegocio.Interfaces;

namespace CrudApi.Dados.Repositorio
{
    public class PagamentoContaRepositorio : Repositorio<PagamentoConta>, IPagamentoContaRepositorio
    {
        public PagamentoContaRepositorio(ContextDB db) : base(db)
        {

        }
    }
}
