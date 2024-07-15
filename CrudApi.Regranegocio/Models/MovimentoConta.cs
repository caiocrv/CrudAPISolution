using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CrudApi.Regranegocio.Utils.Enums;

namespace CrudApi.Regranegocio.Models
{
    public class MovimentoConta : EntidadeBase
    {
        public int IdConta { get; set; }
        public EnTipoMovimento TipoMovimento { get; set; }
        public decimal ValorMovimento { get; set; }
        public int NumeroParcela { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
