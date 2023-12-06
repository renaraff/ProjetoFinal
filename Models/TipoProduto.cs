using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Identificação do tipo de produto")]
        public int Id { get; set; }

        [Column("TipodoProduto")]
        [Display(Name = "Tipo de produto")]
        public string TipodoProduto { get; set; } = string.Empty;
    }
}