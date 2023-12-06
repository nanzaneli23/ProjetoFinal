
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais

    {
        [Column("Id")]
        [Display(Name = "Pais")]

        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do País")]

        public string PaisNome { get; set; } = string.Empty;





    }

}
