using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TrainWithMe.DAL.Entities
{
    public class Plan : Entity
    {
        [Display(Name = "Nivel")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20)]
        public string Level { get; set; }

        public List<PlanExercise> Exercises { get; set; }
    }
}
