using System.ComponentModel.DataAnnotations;

namespace CrudApi.Regranegocio.Models
{
    public abstract class EntidadeBase
    {
        [Key]
        public int Id { get; set; }
    }
}
