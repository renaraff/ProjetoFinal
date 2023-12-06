using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Identificação do cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome completo")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteDataNascimento")]
        [Display(Name = "Data de nascimento")]
        public DateTime ClienteDataNascimento { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "CPF")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumeroCasa")]
        [Display(Name = "Número da casa")]
        public string ClienteNumeroCasa { get; set; } = string.Empty;

        [Column("ClienteBairro")]
        [Display(Name = "Bairro")]
        public string ClienteBairro { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone")]
        public string ClienteTelefone { get; set; } = string.Empty;

    }
}