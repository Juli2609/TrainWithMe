using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TrainWithMe.DAL.Entities;

namespace TrainWithMe.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<PlanExercise> PlanExercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exercise>().HasIndex(e => e.Name).IsUnique();
            modelBuilder.Entity<Plan>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Challenge>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<PlanExercise>().HasIndex("ExerciseId", "PlanId").IsUnique();
        }

    }
}
