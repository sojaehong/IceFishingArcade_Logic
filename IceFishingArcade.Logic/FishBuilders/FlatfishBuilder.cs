using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic.FishBuilders
{
    public class FlatfishBuilder : FishBuilder
    {

        public override void SetFishGrade()
        {
            _fish.FishGrade = "기본";
        }

        public override void SetFishLength()
        {
            _fish.FishLength = _random.Next(20, 100);
        }

        public override void SetFishName()
        {
            _fish.FishName = "광어";
        }

        public override void SetFishSpeed()
        {
            _fish.FishSpeed = 40;
        }

        public override void SetFishWeight()
        {
            _fish.FishWeight = _random.Next(2, 10);
        }
    }
}
