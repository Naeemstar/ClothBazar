using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.services
{
   public class Categoryservices
    {
        public void savecategory(category category)
        {
            using (var context = new CBContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }
        }
        public List<category> getcategory()
        {
            using (var context = new CBContext())
            {
                 return context.categories.ToList();
               
            }
        }
        public category getsanglecategory(int id)
        { 
            using (var context = new CBContext())
            {
                return context.categories.Find(id);

            }
        }
        public void updatecategory(category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
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
        public void deletecategory(category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
