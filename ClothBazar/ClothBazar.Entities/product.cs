using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class product: BaseEntities
    {
        
        public decimal price { get; set; }
        public category category { get; set; }
    }
}
