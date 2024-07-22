using CrudApi.Dados.Context;
using CrudApi.Regranegocio.Models;
using CrudApi.RegraNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApi.Dados.Repositorio
{
    public class ContaRepositorio : Repositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(ContextDB db) : base(db)
        {

        }
    }
}
