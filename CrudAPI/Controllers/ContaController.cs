using CrudApi.RegraNegocio.Interfaces;
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
        public async Tesk
    }
}
