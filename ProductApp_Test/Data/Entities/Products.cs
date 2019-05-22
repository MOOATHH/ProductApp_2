using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp_Test.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int Price { get; set; }
        public string Catagory { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}