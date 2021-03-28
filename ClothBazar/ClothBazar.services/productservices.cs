using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.services
{
   public class productservices
    {
        public void saveproduct(product product)
        {
            using (var context = new CBContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
        public List<product> getproduct()
        {
            using (var context = new CBContext())
            {
                 return context.products.ToList();
               
            }
        }
        public product getsangleproduct(int id)
        { 
            using (var context = new CBContext())
            {
                return context.products.Find(id);

            }
        }
        public void updateproduct(product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        //public category getdeletelecategory(int id)
        //{
        //    using (var context = new CBContext())
        //    {
        //        return context.categories.Find(id);

        //    }
        //}
        public void deleteproduct(product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
