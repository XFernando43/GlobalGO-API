using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public partial class Galerias
    {
        [Key]
        public int idGaleria { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string imagen { get; set; }
    }
}
