using System;
using System.Collections.Generic;
using System.Threading;

namespace FactoryExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's another factory patterns exercise.");
            Console.WriteLine();
            Console.WriteLine("What database would you like to consider working with?");
            Console.WriteLine();
            Console.WriteLine("Available database options are as follows; mongo, sql, and list.");
            Console.WriteLine();
            var userInput = Console.ReadLine(); //we expect a string.
            Console.WriteLine();
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
            
            var logicalInput = new List<string> { "mongo", "sql", "list"};
            do
            {
                if (logicalInput.Contains(userInput))
                {
                    var products = db.LoadData(); //scope format may not be necessary here, but when I ran this program the first few times without them, certain items didn't print to the console.
                    {
                        db.SaveData();
                        Console.WriteLine();
                    }

                        foreach (var product in products)
                    {
                        Console.WriteLine($"Name: {product.Name}, Cost {product.Price}, Condition {product.Condition}"); //what is this called; when we are accessing members inside of these curled brackets? Dot notation.
                    }
                    Console.WriteLine(); //I'd like to make a prompt where it asks the user if they'd like to check out what the other databases have to offer, just with yes or no prompts.
                }
                else
                {
                    Console.WriteLine("Invalid Reponse. Try again");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("What database would you like to consider working with?");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Available database options are as follows; mongo, sql, and list.");
                    Console.WriteLine();
                    userInput = Console.ReadLine(); //variable has already been announced as a string type, so it no longer needs to have string written in front of it, with its continued usage.
                }
        } while (!logicalInput.Contains(userInput)); //really wanted to use the goto-label function here, but once again, TrueCoders says don't do it.

            Console.WriteLine();//if the user has made at least one incorrect repsonse, then we can give them some redemption down here -- else, if we don't rewrite this code in this segment of the main script, they will never
           var productos = db.LoadData(); //see the purpose in having written in a correct answer.
            db.SaveData(); //in other words, we have to give the script something to do, else it won't do anything, just end the program.
            Console.WriteLine(); //had to make a new variable for the list, since I already used 'products' the first time around, but it can still do the same thing.
            foreach (var product in productos) //problem here is if the user responds with an appropriate answer on the first go around, they will have infromation of the selected database show up twice.
            {
                Console.WriteLine($"Name: {product.Name}, Cost {product.Price}, Condition {product.Condition}"); //what is this called; when we are accessing members inside of these curled brackets? Dot notation.
            }
            //Console.WriteLine();
            //Console.WriteLine($"So, you've explored the {userInput} database, would you like to explore another?");
            //Console.WriteLine();
            //Console.WriteLine("You may reply with either yes or no.");
            //Console.WriteLine();
        }
    }
}
