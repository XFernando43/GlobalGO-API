using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public partial class Colores
    {
        [Key]
        public int idColor { get; set; }

        [ForeignKey("modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string color { get; set; }

        [MaxLength(20)]
        public string icono { get; set; }
    }
}
