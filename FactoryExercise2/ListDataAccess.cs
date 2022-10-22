using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class ListDataAccess : IDataAccess //accessible related errors usually reference notions suggesting that certain classes aren't made public. There should be a way for us to default our crafted classes to having public access modifiers.
    {
        public static List<Product> Products = new List<Product>() //implementing the product class here gives this class access to its properties. We make make this class with no return because it doesn't need one, it's just a database.
        { //this where we can write out all of our products and whatever properties we gave them, per the blueprint we designed in the product class.
            new Product(){Name = "Samsung Intensity", Price = 49.99, Condition = "Used, but like new." },
            new Product(){Name = "Samsung Intensity II", Price = 69.99, Condition = "New" },
            new Product(){Name = "Samsung Intensity III", Price = 99.99, Condition = "New" },
            new Product(){Name = "Samsung Galaxy A50", Price = 299.99, Condition = "Used, refurbished." },
            new Product(){Name = "Motorola Razor", Price = 59.99, Condition = "New" },
            new Product(){Name = "Motorola Turbo", Price = 249.99, Condition = "New" },
            new Product(){Name = "Motorola Turbo II", Price = 399.99, Condition = "New" },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("Data is being read from the List Data Access."); //it's nice to be able to fill the scope of a stubbed out method, say from an interface, that hasn't been defined yet, to prevent it from erroring out -- with something like this; throw new NotImplementedException();
            Console.WriteLine(); //just part of how we can write out code as we're thinking about what we want it to do.
            return Products; //this is a quick way to have the information stored in the class written out above this method called. Program class just makes the information stored in this class more efficiently written out
        } //so that we don't have to write out the properties of each product for evey class. Instead, we can just make a class that calls upon the properties of another class.
        public void SaveData()
        {
            Console.WriteLine("Data is being read from the List Data Access.");
        }
    }
}
