using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Cod. Cliente")]
        public int Id { get; set; }

        [Column("CilenteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("CpfCliente")]
        [Display(Name = "CPF do Cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("EnderecoCliente")]
        [Display(Name = "Endereço do Cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;


        [Column("NumeroCasaCliente")]
        [Display(Name = "Número da Casa do Cliente")]
        public string NumeroCasaCliente { get; set; } = string.Empty;


        [Column("BairroCliente")]
        [Display(Name = "Bairro do Cliente")]
        public string BairroCliente { get; set; } = string.Empty;

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do Cliente")]
        public string TelefoneCliente { get; set; } = string.Empty;


        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}