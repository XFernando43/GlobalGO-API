using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public partial class Precios
    {
        [Key]
        public int idPrecio { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [Required]
        public decimal precio { get; set; }

        [Required]
        public DateTime fecha { get; set; }
    }
}
