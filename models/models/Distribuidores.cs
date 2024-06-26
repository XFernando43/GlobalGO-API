using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public class Distribuidores
    {
        [Key]
        public int idDistribuidor { get; set; }

        [Required]
        [MaxLength(100)]
        public string distribuidor { get; set; }

        [Required]
        public string direccion { get; set; }

        [Required]
        [MaxLength(50)]
        public string longitud { get; set; }

        [Required]
        [MaxLength(50)]
        public string latitud { get; set; }

        public ICollection<DistribuidorMotos> distribuidoresMotos { get; set; }
    }
}
