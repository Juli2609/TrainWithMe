namespace TrainWithMe.DAL.Entities
{
    public class PlanExercise
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Guid ExerciseId { get; set; }
    }
}
