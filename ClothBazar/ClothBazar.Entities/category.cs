using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class category: BaseEntities
    {
       
        public List<product> products { get; set; }
    }
}
