﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuantumLearn.Configuration;
using QuantumLearn.Models;

namespace QuantumLearn.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.ApplyConfiguration(new QuestionConfiguration());
        builder.ApplyConfiguration(new AnswerConfiguration());
    }

    public DbSet<Question>? Question { get; set; }
    public DbSet<QuizResult>? QuizResult { get; set; }
    public DbSet<Answer>? Answer { get; set; }
}

// move this to Config folder like Ques & Ans Configs
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u  => u.FirstName).HasMaxLength(255);
        builder.Property(u  => u.LastName).HasMaxLength(255);
    }
}