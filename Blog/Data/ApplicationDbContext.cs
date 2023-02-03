using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Blog.Static;

namespace Blog.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostTag> PostTags { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.IsValid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answers_Comments");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Categori__737584F6E9B4E378")
                    .IsUnique();

                entity.HasIndex(e => e.Slug, "UQ__Categori__BC7B5FB6EFE49953")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Slug).HasMaxLength(50);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(e => e.PostId, "IX_Comments_PostId");

                entity.Property(e => e.Content).HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasMaxLength(50);

                entity.Property(e => e.IsValid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_ToPosts");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_Posts_CategoryId");

                entity.HasIndex(e => e.Slug, "UQ__tmp_ms_x__BC7B5FB65A944A0B")
                    .IsUnique();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.IsPublished).HasDefaultValueSql("((0))");

                entity.Property(e => e.PublishedAt).HasColumnType("datetime");

                entity.Property(e => e.Slug).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_ToCategories");
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.PostId, "IX_PostTags_PostId");

                entity.HasIndex(e => e.TagId, "IX_PostTags_TagId");

                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostTags_ToPosts");

                entity.HasOne(d => d.Tag)
                    .WithMany()
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_PostTags_ToTags");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Tags__737584F6D76DF2E9")
                    .IsUnique();

                entity.HasIndex(e => e.Slug, "UQ__Tags__BC7B5FB6BAD69644")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Slug).HasMaxLength(50);
            });


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "14a926ab-158b-4cbb-8adb-31a51d8d5e4a",
                    Name = AppRoles.User,
                    NormalizedName = AppRoles.User.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "b7871b4d-f86b-41a6-8767-dc9ce09044a1",
                    Name = AppRoles.Admin,
                    NormalizedName = AppRoles.Admin.ToUpper(),
                }
             );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297",
                    Email = "admin@figuil.com",
                    NormalizedEmail = "ADMIN@FIGUIL.COM",
                    UserName = "admin@figuil.com",
                    Pseudonym = "sysadmin",
                    NormalizedUserName = "ADMIN@FIGUIL.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "2910")
                },
                new ApplicationUser
                {
                    Id = "f1ee4fa3-140a-493c-956c-b1aa7775c4f5",
                    Email = "user@figuil.com",
                    NormalizedEmail = "USER@FIGUIL.COM",
                    UserName = "user@figuil.com",
                    Pseudonym = "sysuser",
                    NormalizedUserName = "USER@FIGUIL.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "2910")
                }
             );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b7871b4d-f86b-41a6-8767-dc9ce09044a1",
                    UserId = "a8a16aaaa-bd7e-4db7-b472-b7be15ea5297"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "14a926ab-158b-4cbb-8adb-31a51d8d5e4a",
                    UserId = "f1ee4fa3-140a-493c-956c-b1aa7775c4f5"
                }
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
