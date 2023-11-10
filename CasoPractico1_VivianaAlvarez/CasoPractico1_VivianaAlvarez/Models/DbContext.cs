using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CasoPractico1_VivianaAlvarez.Models
{

public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name=NorthwindContext") { }

      
    }

}
