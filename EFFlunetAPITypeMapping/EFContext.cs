using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFFlunetAPITypeMapping
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Table Name
            modelBuilder.Entity<Employee>().ToTable("mstEmployee");

            //Table Name with schema
            modelBuilder.Entity<Department>().ToTable( "mstDept","admin");

            //Primary Key
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeCode);

            //Composite Primary Key
            modelBuilder.Entity<Department>().HasKey(e => new { e.DeptCode, e.Name });

            //Ignore the Property. Budget column is not created in the table
            modelBuilder.Entity<Department>().Ignore(t => t.Budget);

            //Ignore method disables the creation of table IgnoreThisTable
            modelBuilder.Ignore<IgnoreThisTable>();


            //Complex Type Registration
            modelBuilder.ComplexType<ContactInfo>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<IgnoreThisTable> IgnoreThisTables { get; set; }

      
    }
}
