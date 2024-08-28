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
        public string Modelo { get; set; }
        public string name_color {  get; set; }
        public string hex1 { get; set; }
        public string hex2 { get; set; }
    }
}
