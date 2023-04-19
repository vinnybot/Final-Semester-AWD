using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Linq.Models;

public partial class HenryContext : DbContext
{
    public HenryContext()
    {
    }

    public HenryContext(DbContextOptions<HenryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Wrote> Wrotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=HenryContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorNum).HasName("PK__AUTHOR__7C8480AE");

            entity.ToTable("AUTHOR");

            entity.Property(e => e.AuthorNum)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AUTHOR_NUM");
            entity.Property(e => e.AuthorFirst)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUTHOR_FIRST");
            entity.Property(e => e.AuthorLast)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUTHOR_LAST");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookCode).HasName("PK__BOOK__7E6CC920");

            entity.ToTable("BOOK");

            entity.Property(e => e.BookCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOOK_CODE");
            entity.Property(e => e.Paperback)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAPERBACK");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("PRICE");
            entity.Property(e => e.PublisherCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUBLISHER_CODE");
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TITLE");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchNum).HasName("PK__BRANCH__00551192");

            entity.ToTable("BRANCH");

            entity.Property(e => e.BranchNum)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("BRANCH_NUM");
            entity.Property(e => e.BranchLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BRANCH_LOCATION");
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BRANCH_NAME");
            entity.Property(e => e.NumEmployees)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("NUM_EMPLOYEES");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.BookCode, e.BranchNum }).HasName("PK__INVENTORY__023D5A04");

            entity.ToTable("INVENTORY");

            entity.Property(e => e.BookCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOOK_CODE");
            entity.Property(e => e.BranchNum)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("BRANCH_NUM");
            entity.Property(e => e.OnHand)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("ON_HAND");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherCode).HasName("PK__PUBLISHER__0425A276");

            entity.ToTable("PUBLISHER");

            entity.Property(e => e.PublisherCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUBLISHER_CODE");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CITY");
            entity.Property(e => e.PublisherName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUBLISHER_NAME");
        });

        modelBuilder.Entity<Wrote>(entity =>
        {
            entity.HasKey(e => new { e.BookCode, e.AuthorNum }).HasName("PK__WROTE__060DEAE8");

            entity.ToTable("WROTE");

            entity.Property(e => e.BookCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOOK_CODE");
            entity.Property(e => e.AuthorNum)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("AUTHOR_NUM");
            entity.Property(e => e.Sequence)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("SEQUENCE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
