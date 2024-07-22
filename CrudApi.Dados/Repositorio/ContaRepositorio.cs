﻿using CrudApi.Dados.Context;
using CrudApi.Regranegocio.Models;
using CrudApi.RegraNegocio.Interfaces;

namespace CrudApi.Dados.Repositorio
{
    public class ContaRepositorio : Repositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(ContextDB db) : base(db)
        {

        }
    }
}
