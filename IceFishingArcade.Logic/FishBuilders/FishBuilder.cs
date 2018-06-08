using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic.FishBuilders
{
    public abstract class FishBuilder
    {
        protected Fish _fish = new Fish();

        public Fish Fish
        {
            get { return _fish; }
        }

        public static Random _random = new Random();

        public abstract void SetFishName();

        public abstract void SetFishWeight();

        public abstract void SetFishLength();

        public abstract void SetFishGrade();

        public abstract void SetFishSpeed();
    }
}
