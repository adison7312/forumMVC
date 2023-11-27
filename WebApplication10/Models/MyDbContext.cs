using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

//Mechanizm Migrations
//1. Enable-Migrations - raz na początku życia projektu
//2a. Add-Migration NAZWA - po zmianie modeli
//2b. Update-Database - zmiana po stronie bazy danych 

namespace WebApplication10.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyCS") { }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Threads> Threads { get; set; }
        public DbSet<BannedList> BannedList { get; set; }
        public DbSet<Attachments> Attachments { get; set; }
        public DbSet<ForumCategories> ForumCategories { get; set; }
        public DbSet<Forums> Forums { get; set; }
        public DbSet<ModeratorAssignments> ModeratorAssignments { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<PrivateMessages> PrivateMessages { get; set; }
        public DbSet<Ranks> Ranks { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}