using clothBaazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBaazar.Database
{
   public class CBContext : DbContext
    {

        public CBContext() : base("ClothBaazarConnection")
        {
             
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}
