using CrudApi.Regranegocio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CrudApi.Dados.Context
{
	public class ContextDB : IdentityDbContext
	{
		public ContextDB(DbContextOptions<ContextDB> options) : base(options)
		{

		}

		public DbSet<Conta> Contas { get; set; }
		public DbSet<MovimentoConta> MovimentoContas { get; set; }
		public DbSet<PagamentoConta> PagamentoConta { get; set; }
	}
}
