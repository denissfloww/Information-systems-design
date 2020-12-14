namespace RegistryServer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrganizationContext : DbContext
    {       
        public OrganizationContext()
            : base("name=OrganizationContext")
        {
        }

        public DbSet<Organization> Organization { get; set; }
    }
}