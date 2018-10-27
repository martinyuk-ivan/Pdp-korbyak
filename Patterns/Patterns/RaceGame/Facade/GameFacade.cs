using Patterns.RaceGame.CarModels;
using Patterns.RaceGame.DriveEngine.Comand;
using Patterns.RaceGame.DriveEngine.Comand.Drive;
using Patterns.RaceGame.Factories.CarFactory;

namespace Patterns.RaceGame.Facade
{
    public class CarFacade
    {
        private BaseCar myCar;
        private TurnSystem turnSystem;

        public CarFacade()
        {
            this.turnSystem = new TurnSystem(this.myCar);
        }

        public void ChooseCar(CarType type)
        {
            myCar = FactoryMethod.Create(type);
        }

        public void DriveTo(Direction direction)
        {
            IDriveComand driveCommand = new DriveComand(this.turnSystem, direction);
            driveCommand.Execute();
        }
    }
}
