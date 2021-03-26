using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
   public class CBContext : DbContext,IDisposable
    {
        public CBContext():base("Cs")
        {

        }
       public DbSet<category> categories { get; set; }
      public   DbSet<product> products { get; set; }
    }
}
