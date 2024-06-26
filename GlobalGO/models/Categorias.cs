using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public class Categorias
    {
        [Key]
        public int idCategoria { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string categoria { get; set; }

        [MaxLength(20)]
        public string icono { get; set; }
    }
}
