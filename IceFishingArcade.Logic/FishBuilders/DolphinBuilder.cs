using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic.FishBuilders
{
    class DolphinBuilder : FishBuilder
    {

        public override void SetFishGrade()
        {
            _fish.FishGrade = "희귀";
        }

        public override void SetFishLength()
        {
            _fish.FishLength = _random.Next(100, 200);
        }

        public override void SetFishName()
        {
            _fish.FishName = "돌고래";
        }

        public override void SetFishSpeed()
        {
            _fish.FishSpeed = 90;
        }

        public override void SetFishWeight()
        {
            _fish.FishWeight = _random.Next(50, 200);
        }
    }
}
