using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Drawing;

namespace ProductManagement.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        //public HttpPostedFileBase SmallImage { get; set; }
        //public HttpPostedFileBase LargeImage { get; set; }
    }
    public enum Categories
    {
        FruitsVegetables,
        CleaningStuff,
        Stationery,
        Snacks
    }
    public class ProductsDBContext : DbContext
    {
       
        public ProductsDBContext()
        { }
        public DbSet<Products> Products { get; set; }
        //public DbSet<Image> Images { get; set; }
    }
}