using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApi.Regranegocio.Models
{
    public class PagamentoConta : EntidadeBase
    {
        public int IdMovimentoConta { get; set; }
        public int NumeroParcela { get; set; }
        public decimal ValorMovimento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorDesconto { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
