using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public partial class Modelos
    {

        [Key]
        public int idModelo { get; set; }

        [ForeignKey("marca")]
        public int idMarca { get; set; }
        public Marcas marca { get; set; }

        [MaxLength(100)]
        public string modelo { get; set; }

        public string slogan { get; set; }
        public string texto { get; set; }

        [MaxLength(100)]
        public string video { get; set; }

        [MaxLength(20)]
        public string logo { get; set; }

        [MaxLength(7)]
        public string rgb { get; set; }

        public ICollection<Colores> colores { get; set; }
        public ICollection<Categorias> categorias { get; set; }
        public ICollection<Especificaciones> especificaciones { get; set; }
        public ICollection<Carruseles> carruseles { get; set; }
        public ICollection<Galerias> galerias { get; set; }
        public ICollection<Precios> precios { get; set; }
        public ICollection<DistribuidorMotos> distribuidoresMotos { get; set; }
    }
}
