using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Identificação do tipo de saída")]
        public int Id { get; set; }

        [Column("TipodeSaida")]
        [Display(Name = "Tipo de saída")]
        public string TipodeSaida { get; set; } = string.Empty;
    }
}