using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TrainWithMe.DAL.Entities
{
    public class Challenge : Entity
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Descripción")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Ejercicio")]
        public ICollection<Exercise> Exercise { get; set; }
        public int ExcerciseNumber => Exercise == null ? 0 : Exercise.Count();
    }
}
