using CrudAPI.Dados.Context;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Dados.Repositorio
{
    public class ContaRepositorio : Repositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(ContextDB db) : base(db)
        {
        }
    }
}
