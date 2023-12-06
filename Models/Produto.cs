using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Identificação do produto")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoQuantidade")]
        [Display(Name = "Quantidade em estoque")]
        public int ProdutoQuantidade { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo de produto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
