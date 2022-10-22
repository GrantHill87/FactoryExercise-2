using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2 //tightly coupled program, vs a loosely coupled program -- when code of said program is altered, will dictate whether or not other code within the same program must also be adjusted to fit to the change.
{
    public static class DataAccessFactory
    {
    public static IDataAccess GetDataAccessType(string databaseType) //this where the 'GetDataAccessType' method is created. I think we make this method static so that we don't have be forced to make instances of it, we just use it for what we want to at run time.
        {
            switch (databaseType.ToLower()) //what are we switching on? A database type.
            {
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDataAccess();
                case "list":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess(); //cannot write in the break function here, as it will cause the 'GetDataAccessType' method to error, suggesting that not all code paths return a value 
                    //-- seems to be referring to the default aspect of the switch function not having a return. Perhaps, we could return a null value here if we wanted.
            }
        }
    }

}
