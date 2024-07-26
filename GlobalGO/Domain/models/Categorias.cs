using System.ComponentModel.DataAnnotations;

namespace GlobalGO.models
{
    public class Categorias
    {
        [Key]
        public int idCategoria { get; set; }

        //[ForeignKey("Modelo")]
        //public int idModelo { get; set; }
        //public Modelos modelo { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string categoria { get; set; }

        //[MaxLength(20)]
        public string icono { get; set; }
    }
}
