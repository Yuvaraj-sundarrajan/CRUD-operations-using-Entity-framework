using Microsoft.EntityFrameworkCore;

namespace Ef_Traineemanagement{

    public class TraineeContext:DbContext{
          public DbSet<Trainee> Traineedetails { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=EfTrainee;user=root;password=root");
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Trainee>(entity =>
      {
        entity.HasKey(e => e.Empno);
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Domain).IsRequired();
        entity.Property(e => e.worklocation).IsRequired();

      });

    }


    }
}