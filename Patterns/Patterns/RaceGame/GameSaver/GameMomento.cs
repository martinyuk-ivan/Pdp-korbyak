using Patterns.RaceGame.CarModels;
using Patterns.RaceGame.RoadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.GameSaver
{
    public class GameMomento
    {
        private BaseCar car;

        private Road road;

        public GameMomento(BaseCar car, Road currentRoad)
        {
            this.car = car;
            this.road = currentRoad;
        }
    }
}
