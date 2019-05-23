using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Service_Station_Manager
{
    class ProjectContext : DbContext
    {
        public ProjectContext() : base("DBConnection")
        { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Installation> Installations { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<TypesOfWork> TypesOfWorks { get; set; }

    }
}
