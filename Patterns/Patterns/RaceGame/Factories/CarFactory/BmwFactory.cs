using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.RaceGame.CarModels;

namespace Patterns.RaceGame.Factories.CarFactory
{
    public class BmwFactory : ICarFactory
    {
        public BaseCar Create()
        {
            return new BMWX5();
        }
    }
}
