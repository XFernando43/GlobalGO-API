using System.ComponentModel.DataAnnotations;

namespace GlobalGO.models
{
    public partial class Marcas
    {
        [Key]
        public int idMarca { get; set; }

        [Required]
        [MaxLength(50)]
        public string marca { get; set; }

        [Required]
        [MaxLength(20)]
        public string logo { get; set; }

        [MaxLength(7)]
        public string rgb { get; set; }

        public ICollection<Modelos> modelos { get; set; }
    }
}
