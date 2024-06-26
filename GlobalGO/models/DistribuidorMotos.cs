using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalGO.models
{
    public class DistribuidorMotos
    {
        [Key]
        public int idDealerMoto { get; set; }

        [ForeignKey("Distribuidor")]
        public int idDistribuidor { get; set; }
        public Distribuidores distribuidor { get; set; }

        [ForeignKey("Modelo")]
        public int idModelo { get; set; }
        public Modelos modelo { get; set; }
    }
}
