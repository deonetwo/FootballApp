using System;
using System.Collections.Generic;
using FootballApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballApp.Server.Data;

public partial class FootballDbContext : DbContext
{
    public FootballDbContext(DbContextOptions<FootballDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Position).WithMany(p => p.Players)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Players_Positions");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
