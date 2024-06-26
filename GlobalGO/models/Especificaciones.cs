using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public partial class Especificaciones
    {
        [Key]
        public int idEspecificacion { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }

        [MaxLength(50)]
        public string imagen { get; set; }

        [MaxLength(50)]
        public string anio { get; set; }

        [MaxLength(20)]
        public string cilindrada { get; set; }

        [MaxLength(20)]
        public string potencia { get; set; }

        [MaxLength(20)]
        public string torque { get; set; }

        [MaxLength(20)]
        public string combustible { get; set; }

        [MaxLength(20)]
        public string tanque { get; set; }

        [MaxLength(20)]
        public string rendimiento { get; set; }

        [MaxLength(20)]
        public string autonomia { get; set; }

        [MaxLength(20)]
        public string transmision { get; set; }

        [MaxLength(20)]
        public string velocidad { get; set; }

        [MaxLength(20)]
        public string freno_delantero { get; set; }

        [MaxLength(20)]
        public string freno_posterior { get; set; }

        [MaxLength(20)]
        public string suspension_delantero { get; set; }

        [MaxLength(20)]
        public string suspension_posterior { get; set; }

        [MaxLength(20)]
        public string peso { get; set; }

        [MaxLength(20)]
        public string carga { get; set; }

        [MaxLength(20)]
        public string largo { get; set; }

        [MaxLength(20)]
        public string ancho { get; set; }

        [MaxLength(20)]
        public string alto { get; set; }
    }
}
