using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formation.Domain.Entity;

namespace Formation.Data
{
    public class FormationContext:DbContext
    {
        public FormationContext():base("name=ConnexionString")
        {

        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Producer> Producers { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}
