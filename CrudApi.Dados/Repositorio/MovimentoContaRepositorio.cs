﻿using CrudAPI.Dados.Context;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Dados.Repositorio
{
    public class MovimentoContaRepositorio : Repositorio<MovimentoConta>, IMovimentoContaRepositorio
    {
        public MovimentoContaRepositorio(ContextDB db) : base(db)
        {
        }

        public async Task<MovimentoConta> ObterPorId(int id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
