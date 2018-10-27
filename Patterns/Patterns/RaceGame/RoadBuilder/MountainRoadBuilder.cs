using System;
using Patterns.RaceGame.RoadModels;
using Patterns.RaceGame.CarModels;
using System.Collections.Generic;

namespace Patterns.RaceGame.RoadBuilder
{
    public class MountainRoadBuilder : RoadBuilder
    {
        public MountainRoadBuilder(Road road) : base(road)
        {
        }

        public override void SetCars()
        {
            var cars = new List<BaseCar>();

            for (int i = 0; i < r.Next(10, 15); i++)
            {
                cars.Add(this.carFactory.Create());
            }

            this.road.Cars = cars;
        }

        public override void SetDistance()
        {
            this.road.Distance = r.Next(5, 10);
        }

        public override void SetType()
        {
            this.road.Type = RoadType.MountainRoad;
        }
    }
}
