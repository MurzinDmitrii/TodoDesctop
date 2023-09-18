using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication2.Models;

public partial class TodoContext : DbContext
{
    public TodoContext()
    {
    }

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Todo;Username=postgres;Password=qwe");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.Description).HasName("Todo_pkey");

            entity.ToTable("Todo");

            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Check).HasColumnName("check");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
