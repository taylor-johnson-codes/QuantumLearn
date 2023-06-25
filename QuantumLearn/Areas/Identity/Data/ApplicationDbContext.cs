using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuantumLearn.Areas.Identity.Data;
using QuantumLearn.Models;

namespace QuantumLearn.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
    //public DbSet<SeedData> SeedDatas { get; set; }  // can't be here because it's a static class; had to move this functionality to Program.cs
    //public DbSet<Question> Questions { get; set; }
    //public DbSet<Answer> Answers { get; set; }
    //public DbSet<QuizResult> QuizResults { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        // from https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio
        //builder.Entity<Question>().ToTable("Question");
        //builder.Entity<Answer>().ToTable("Answer");
        //builder.Entity<QuizResult>().ToTable("QuizResult");
        //builder.Entity<SeedData>().ToTable("SeedData");  // can't be here because it's a static class; had to move this functionality to Program.cs
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u  => u.FirstName).HasMaxLength(255);
        builder.Property(u  => u.LastName).HasMaxLength(255);
    }
}