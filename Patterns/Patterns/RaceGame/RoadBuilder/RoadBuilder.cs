using Patterns.RaceGame.Factories.CarFactory;
using Patterns.RaceGame.RoadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.RoadBuilder
{
    public abstract class RoadBuilder
    {
        protected Road road;

        protected Random random;

        protected ICarFactory carFactory;

        public RoadBuilder(Road road)
        {
            this.random = new Random();
            this.road = road;
        }

        public abstract void SetDistance();

        public void SetTrafficSize()
        {
            this.road.TrafficSize = this.road.Cars.Count;
        }

        public abstract void SetCars();

        public abstract void SetType();

        public Road GetRoad()
        {
            return road;
        }
    }
}
