using Patterns.RaceGame.CarModels;

namespace Patterns.RaceGame.Factories.CarFactory
{
    public class LamborginiFactory : ICarFactory
    {
        public BaseCar Create()
        {
            return new Lamborgini();
        }
    }
}
