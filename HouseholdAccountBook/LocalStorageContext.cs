using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseholdAccountBook.DataBase
{
    internal class LocalStorageContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Data> data { get; set; }

        public string dbPath { get; }

        public LocalStorageContext()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            dbPath = $"{path}{Path.DirectorySeparatorChar}RecordHistories";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
