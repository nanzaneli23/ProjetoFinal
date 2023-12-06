using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {

        [Column("Id")]
        [Display(Name = "Cód. Fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do Fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("EmailFornecedor")]
        [Display(Name = "Email")]

        public string EmailFornecedor { get; set; } = string.Empty;

        [Column("CnpjFornecedor")]
        [Display(Name = "CNPJ")]

        public string CnpjFornecedor { get; set; } = string.Empty;
    }
}