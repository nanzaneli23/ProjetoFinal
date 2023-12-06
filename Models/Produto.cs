using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Cód. Produto")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do Produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade em Estoque ")]
        public int ProdutoEstoque { get; set; }

        
        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo Produto")]
        public int TipoProdutoId { get; set; }

        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }

        public Fornecedor? Fornecedor { get; set; }


    }
}
