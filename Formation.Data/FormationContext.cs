using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation.Data
{
    public class FormationContext:DbContext
    {
        public FormationContext():base("name=ConnexionString")
        {

        }

    }
}
