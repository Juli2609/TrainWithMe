using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TrainWithMe.DAL.Entities
{
    public class Exercise : Entity
    {
        [Required]
        [Display(Name = "Descripción")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Nivel")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(20)]
        public string Level { get; set; }

        [Display(Name = "Video Ejercicio")]
        public string? ExerciseVideo { get; set; }

        public List<PlanExercise> Plans { get; set; }

        [Display(Name = "Reto")]
        public Challenge Challenge { get; set; }
        public Guid ChallengeId { get; set; }
    }
}
