using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.App.Controllers
{
    [Route("[controller]")]
    public class ContaController : Controller
    {
        IContaRepositorio _IContaRepositorio;
        public ContaController(IContaRepositorio iContaRepositorio)
        {
            _IContaRepositorio = iContaRepositorio;
        }

        [HttpGet("obter-todas")]
        public async Task<ActionResult<IEnumerable<Conta>>> ObterTodas()
        {
            var contas = await _IContaRepositorio.ObterTodos();
            return Ok(contas);
        }




    }
}
