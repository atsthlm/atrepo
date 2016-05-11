namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Employees.AddOrUpdate(
                e => e.FirstName,
                new Employee { FirstName = "Kalle" LastName = "Karlsson" Salary = "25.000" Position = "Receptionist" Department = "Huvudkontoret" Company = "F�retag ABC" },
                new Employee { FirstName = "Anders" LastName = "Svensson" Salary = "20.000" Position = "Vaktm�stare" Department = "Annexet" Company = "F�retag ABC" },
                new Employee { FirstName = "Stefan" LastName = "Larsson" Salary = "30.000" Position = "L�nehandl�ggare" Department = "HR" Company = "F�retag ABC" }

                );
        }
    }
}
