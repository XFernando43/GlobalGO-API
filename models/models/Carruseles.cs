using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public class Carruseles
    {
        [Key]
        public int idCarrusel { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string imagen { get; set; }

        [MaxLength(60)]
        public string titulo { get; set; }

        [MaxLength(60)]
        public string texto1 { get; set; }

        [MaxLength(60)]
        public string texto2 { get; set; }
    }
}
