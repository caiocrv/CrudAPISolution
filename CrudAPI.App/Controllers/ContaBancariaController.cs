using CrudAPI.Dados.Repositorio;
using CrudAPI.RegraNegocio.Interfaces;
using CrudAPI.RegraNegocio.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.App.Controllers
{
    public class ContaBancariaController : Controller
    {
        IContaBancariaRepositorio _IContaBancariaRepositorio;
        public ContaBancariaController(IContaBancariaRepositorio iContaBancariaRepositorio)
        {
            _IContaBancariaRepositorio = iContaBancariaRepositorio;
        }

        [HttpGet("obter-todas")]
        public async Task<ActionResult<IEnumerable<ContaBancaria>>> ObterTodas()
        {
            var contaBancaria = await _IContaBancariaRepositorio.ObterTodos();
            return Ok(contaBancaria);
        }

        [HttpPost("incluir-conta-bancaria")]
        public async Task<ActionResult<ContaBancaria>> Adicionar(ContaBancaria contaBancaria)
        {
            try
            {
                await _IContaBancariaRepositorio.Adicionar(contaBancaria);
                return Ok(contaBancaria);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("alterar-conta-bancaria")]
        public async Task<ActionResult<ContaBancaria>> Atualizar([FromQuery] int id, [FromBody] ContaBancaria contaBancaria)
        {
            try
            {
                var contaBancariaAtual = await _IContaBancariaRepositorio.ObterPorId(id);

                if (contaBancariaAtual == null || contaBancariaAtual.Id == 0)
                {
                    return NotFound();
                }

                contaBancaria.Id = contaBancariaAtual.Id;
                await _IContaBancariaRepositorio.Atualizar(contaBancaria);

                return Ok(contaBancaria);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("excluir-conta-bancaria")]
        public async Task<ActionResult> Deletar(int id)
        {
            try
            {
                var contaBancaria = await _IContaBancariaRepositorio.ObterPorId(id);

                if (contaBancaria == null || contaBancaria.Id == 0)
                {
                    return Ok();
                }

                await _IContaBancariaRepositorio.Remover(contaBancaria);

                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
