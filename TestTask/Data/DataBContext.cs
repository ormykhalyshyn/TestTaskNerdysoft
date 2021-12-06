using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Data
{
    public class DataBContext:DbContext
    {
        public DataBContext(DbContextOptions<DataBContext> options) : base(options)
        {

        }
        public DbSet<Announcement> Announcements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>().ToTable("Announcement");
        }
    }
}
