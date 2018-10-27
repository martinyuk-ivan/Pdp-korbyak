using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.RaceGame.RoadModels;
using Patterns.RaceGame.CarModels;

namespace Patterns.RaceGame.RoadBuilder
{
    public class SpeedWayRoadBuilder : RoadBuilder
    {
        public SpeedWayRoadBuilder(Road road) : base(road)
        {
        }

        public override void SetCars()
        {
            var cars = new List<BaseCar>();

            for (int i = 0; i < random.Next(100, 185); i++)
            {
                cars.Add(this.carFactory.Create());
            }

            this.road.Cars = cars;
        }

        public override void SetDistance()
        {
            this.road.Distance = random.Next(500, 1000);
        }

        public override void SetType()
        {
            this.road.Type = RoadType.SpeedWay;
        }
    }
}
