using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic.FishBuilders
{
    class SeaTurtleBuilder : FishBuilder
    {
        public override void SetFishGrade()
        {
            _fish.FishGrade = "희귀";
        }

        public override void SetFishLength()
        {
            _fish.FishLength = _random.Next(100, 400);
        }

        public override void SetFishName()
        {
            _fish.FishName = "바다거북이";
        }

        public override void SetFishSpeed()
        {
            _fish.FishSpeed = 80;
        }

        public override void SetFishWeight()
        {
            _fish.FishWeight = _random.Next(180, 300);
        }
    }
}
