using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Xbox", Price = 400.99, Condition = "New"},
            new Product(){Name = "Playstation 2", Price = 200.99, Condition = "New"},
            new Product(){Name = "Dreamcast", Price = 201.99, Condition = "New"},
            new Product(){Name = "N64", Price = 189.99, Condition = "New"},
            new Product(){Name = "Game Cube", Price = 0, Condition = "Used, with lots of scratches." },
            new Product(){Name = "Genesis", Price = 140.99, Condition = "Used, with minor scratches." },
            new Product(){Name = "Saturn", Price = 109.99, Condition = "Used, appears to be leaking." },
            new Product(){Name = "Super Nintendo", Price = 89.99, Condition = "Used, previous user reported game cartridges sticking to the inside of the port." }
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Data is being read from SQL Data Access.");
            return Products;
        }
        public void SaveData()
        {
           Console.WriteLine("Data is being saved on SQL Data Access.");
        }
    }
}