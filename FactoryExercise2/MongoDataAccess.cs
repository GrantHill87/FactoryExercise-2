using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Saw", Price = 5.99, Condition = "Used" },
            new Product() { Name = "Saw II", Price = 6.99, Condition = "Used" },
            new Product() { Name = "Darkness Falls", Price = 4.99, Condition = "Used" },
            new Product() { Name = "Mama", Price = 8.99, Condition = "Used" },
            new Product() {Name = "The Houses October Built", Price = 9.99, Condition = "Used" },
            new Product() {Name = "Insidious", Price = 7.99, Condition = "Used" },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Data is being read from the Mongo Data Access.");
            Console.WriteLine();
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine("Data is being saved to the Mongo Data Access.");
        }
    }
}
