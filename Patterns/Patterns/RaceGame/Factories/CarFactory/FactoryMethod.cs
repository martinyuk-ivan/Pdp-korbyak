using Patterns.RaceGame.CarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.Factories.CarFactory
{
    public static class FactoryMethod
    {
        static BmwFactory bmwFactory = new BmwFactory();
        static LamborginiFactory lamborginiFactory = new LamborginiFactory();

        public static BaseCar Create(CarType cartype)
        {
            BaseCar car= null;

            switch (cartype)
            {
                case CarType.Sport:
                    car = lamborginiFactory.Create();
                break;
                case CarType.Suv:
                    car = bmwFactory.Create();
                break;
            }

            return car;
        }
    }
}
