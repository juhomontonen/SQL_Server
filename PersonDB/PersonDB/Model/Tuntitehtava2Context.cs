using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PersonDB.Model
{
    public partial class Tuntitehtava2Context : DbContext
    {
        public virtual DbSet<Table1Person> Table1Person { get; set; }
        public virtual DbSet<Table2Phone> Table2Phone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-91I8T38L\SQLEXPRESS;Initial Catalog=Tuntitehtava2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table2Phone>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Table2Phone)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Table_2_Phone_Table_1_Person");
            });
        }
    }
}
