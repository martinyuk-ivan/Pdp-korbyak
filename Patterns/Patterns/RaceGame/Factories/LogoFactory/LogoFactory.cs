using Patterns.RaceGame.CarModels.CarLogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.Factories.LogoFactory
{
    public static class LogoFactory
    {
        // Flyweight
        static Dictionary<string, CarLogo> carLogos = new Dictionary<string, CarLogo>();

        public static CarLogo CreateLogo(string carName)
        {
            if (!carLogos.ContainsKey(carName))
            {
                carLogos.Add(carName, new CarLogo()); // just simple mocks
            }

            return carLogos[carName];
        }
    }
}
