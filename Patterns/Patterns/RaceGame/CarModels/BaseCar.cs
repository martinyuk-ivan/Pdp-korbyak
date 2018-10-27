using Patterns.RaceGame.Factories.LogoFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RaceGame.CarModels
{
    public abstract class BaseCar
    {
        public BaseCar()
        {
            this.InitCar();
        }

        public Positioning CarPosition { get; set; }

        public CarLogo.CarLogo CarLogo { get { return this.LoadCarLogo(); } }

        public int MaxSpeed { get; protected set; }

        public string CarName { get; protected set; }

        public string CarColor { get; set; }

        public abstract CarType CarType { get; }

        public DateTime DateOfIssue { get; protected set; }

        //template method pattern
        protected abstract void InitCar();

        private CarLogo.CarLogo LoadCarLogo()
        {
            return LogoFactory.CreateLogo(this.CarName);
        }
    }
}
