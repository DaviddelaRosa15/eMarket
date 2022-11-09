using Microsoft.EntityFrameworkCore;
using eMarket.Core.Domain.Common;
using eMarket.Core.Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eMarket.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
        #region Sets
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region tables

            modelBuilder.Entity<Article>()
                .ToTable("Articles");

            modelBuilder.Entity<Category>()
                .ToTable("Categories");

            modelBuilder.Entity<User>()
                .ToTable("Users");

            #endregion

            #region "primary keys"
            modelBuilder.Entity<Article>()
                .HasKey(article => article.Id);

            modelBuilder.Entity<Category>()
                .HasKey(category => category.Id);

            modelBuilder.Entity<User>()
              .HasKey(user => user.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Category>()
                .HasMany<Article>(article => article.Articles)
                .WithOne(article => article.Category)
                .HasForeignKey(article => article.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
             .HasMany<Article>(article => article.Articles)
                .WithOne(article => article.User)
                .HasForeignKey(article => article.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Property configurations

            #region articles

            modelBuilder.Entity<Article>().
                Property(article => article.Name)
                .IsRequired();

            modelBuilder.Entity<Article>().
               Property(article => article.Price)
               .IsRequired();

            modelBuilder.Entity<Article>().
               Property(article => article.Description)
               .IsRequired();

            #endregion

            #region categories
            modelBuilder.Entity<Category>().
              Property(category => category.Name)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Category>().
              Property(category => category.Description)
              .IsRequired();
            #endregion

            #region users

            modelBuilder.Entity<User>().
                Property(user => user.Name)
                .IsRequired();

            modelBuilder.Entity<User>().
                Property(user => user.LastName)
                .IsRequired();

            modelBuilder.Entity<User>().
               Property(user => user.Username)
               .IsRequired();

            modelBuilder.Entity<User>().
              Property(user => user.Password)
              .IsRequired();

            modelBuilder.Entity<User>().
              Property(user => user.Email)
              .IsRequired();

            modelBuilder.Entity<User>().
               Property(user => user.Phone)
               .IsRequired();

            #endregion

            #endregion
        }

    }
}
