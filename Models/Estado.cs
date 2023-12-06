using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Identificação do estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        [Display(Name = "País")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}