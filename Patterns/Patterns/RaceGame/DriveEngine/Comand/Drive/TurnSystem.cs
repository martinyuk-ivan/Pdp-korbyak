using Patterns.RaceGame.CarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.DriveEngine.Comand.Drive
{
    public abstract class TurnSystem
    {
        protected BaseCar car;

        public TurnSystem(BaseCar car)
        {
            this.car = car;
        }

        public void TurnOnLeft()
        {
            this.car.CarPosition.X -= 10;
        }

        public void TurnOnRight()
        {
            this.car.CarPosition.X += 10;
        }

        public void SpeedUp()
        {
            this.car.CarPosition.Y += 100;
        }

        public void SpeedDown()
        {
            this.car.CarPosition.Y -= 100;
        }
    }
}
