using CrudAPI.RegraNegocio.Models;

namespace CrudAPI.RegraNegocio.Interfaces
{
    public interface IContaBancariaRepositorio: IRepositorio<ContaBancaria>
    {
        Task<ContaBancaria> ObterPorId(int id);
    }
}
