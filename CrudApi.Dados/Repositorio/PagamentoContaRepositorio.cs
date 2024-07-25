using CrudAPI.Dados.Context;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;

namespace CrudAPI.Dados.Repositorio
{
    public class PagamentoContaRepositorio : Repositorio<PagamentoConta>, IPagamentoContaRepositorio
    {
        public PagamentoContaRepositorio(ContextDB db) : base(db)
        {
        }
    }
}
