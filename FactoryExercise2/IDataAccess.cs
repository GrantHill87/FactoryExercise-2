using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    public interface IDataAccess //remember to make this class publicly accessible. If it's not, then it cannot be accessed by the other classes that want to use it.
    {
        public void SaveData();
        public List<Product> LoadData();
    }
}
