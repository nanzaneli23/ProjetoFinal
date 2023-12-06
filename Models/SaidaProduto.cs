using ProjetoFinal.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{

    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Cod. Saída")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("QuantidadeSaida")]
        [Display(Name = "Quantidade")]
        public int QuantidadeSaida { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data da Saída")]
        public DateTime DataSaida { get; set; }

        
        [ForeignKey("TipoSaidaId")]
        [Display(Name = "Tipo Saída")]
        public int TipoSaidaId { get; set; }

        public TipoSaida? TipoSaida { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
