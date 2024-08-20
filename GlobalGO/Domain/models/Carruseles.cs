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
        public int IdCarrusel { get; set; }
        public int IdModelo { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string Texto1 { get; set; }
        public string Texto2 { get; set; }
    }
}
