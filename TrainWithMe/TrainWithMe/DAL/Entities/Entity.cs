using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TrainWithMe.DAL.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre del Ejercicio")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo de Ejercicio")]
        [MaxLength(50)]
        public string Type { get; set; }
    }

}
