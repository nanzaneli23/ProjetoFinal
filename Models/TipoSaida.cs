using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Codigo do Tipo da Saída")]

        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descrição da Saida")]

        public string TipoSaidaDescricao { get; set; } = string.Empty;

    }
}