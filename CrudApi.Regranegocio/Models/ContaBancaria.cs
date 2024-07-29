using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.RegraNegocio.Models
{
    public class ContaBancaria : EntidadeBase
    {
        public int IdContaBancaria { get; set; }
        public string NomeBanco { get; set; } = string.Empty;
        public int Agencia { get; set; }
        public string NomeConta {  get; set; } = string.Empty;
    }
}
