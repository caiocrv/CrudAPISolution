using CrudApi.Regranegocio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CrudApi.Regranegocio.Utils.Enums;

namespace CrudApi.Regranegocio.Models
{
    public class Conta : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;
        public EnTipoContas TipoConta { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}
