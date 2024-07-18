using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CrudApi.Regranegocio.Utils.Enums;

namespace CrudApi.Regranegocio.Models
{
    //data annotation
    [Table("Conta")]
    public class Conta : EntidadeBase
    {
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        public EnTipoContas TipoConta { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}

