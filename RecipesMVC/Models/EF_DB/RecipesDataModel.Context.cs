﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipesMVC.Models.EF_DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecipesAppEntities : DbContext
    {
        public RecipesAppEntities()
            : base("name=RecipesAppEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Ratings of Recipes
            modelBuilder.Entity<Rating>().HasRequired<Recipe>(ra => ra.Recipe).WithMany(re => re.Ratings).HasForeignKey(ra => ra.Recipe_ID);
            modelBuilder.Entity<Recipe>().HasMany<Rating>(re => re.Ratings).WithRequired(ra => ra.Recipe).HasForeignKey(ra => ra.Recipe_ID).WillCascadeOnDelete(true);
            //Recipes of user
            modelBuilder.Entity<Recipe>().HasRequired<User>(re => re.User).WithMany(u => u.Recipes).HasForeignKey(re => re.UserID);
            modelBuilder.Entity<User>().HasMany<Recipe>(u => u.Recipes).WithRequired(re => re.User).HasForeignKey(re => re.UserID).WillCascadeOnDelete(true);
            //Ratings of user
            modelBuilder.Entity<Rating>().HasRequired<User>(ra => ra.User).WithMany(u => u.Ratings).HasForeignKey(ra => ra.UserID);
            modelBuilder.Entity<User>().HasMany<Rating>(u => u.Ratings).WithRequired(ra => ra.User).HasForeignKey(ra => ra.UserID).WillCascadeOnDelete(true);
            //Recipes of Categories
            modelBuilder.Entity<Recipe>().HasRequired<Category>(re => re.Category).WithMany(c => c.Recipes).HasForeignKey(re => re.CategoryID);
            modelBuilder.Entity<Category>().HasMany<Recipe>(c => c.Recipes).WithRequired(re => re.Category).HasForeignKey(re => re.CategoryID).WillCascadeOnDelete(true);
            //Favorites of user
            modelBuilder.Entity<Favorite>().HasRequired<User>(f => f.User).WithMany(u => u.Favorites1).HasForeignKey(f => f.UserID);
            modelBuilder.Entity<User>().HasMany<Favorite>(u => u.Favorites1).WithRequired(f => f.User).HasForeignKey(f => f.UserID).WillCascadeOnDelete(true);
            //Favorites of recipe
            modelBuilder.Entity<Favorite>().HasRequired<Recipe>(f => f.Recipe).WithMany(re => re.Favorites).HasForeignKey(f => f.RecipeID);
            modelBuilder.Entity<Recipe>().HasMany<Favorite>(re => re.Favorites).WithRequired(f => f.Recipe).HasForeignKey(f => f.RecipeID).WillCascadeOnDelete(true);
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
    }
}
