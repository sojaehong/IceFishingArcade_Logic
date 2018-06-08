using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceFishingArcade.Logic.FishBuilders;

namespace IceFishingArcade.Logic
{
    public class FishFactory
    {
        private static Fish CreateCore(FishBuilder fishBuilders)
        {
            fishBuilders.SetFishGrade();
            fishBuilders.SetFishLength();
            fishBuilders.SetFishName();
            fishBuilders.SetFishSpeed();
            fishBuilders.SetFishWeight();

            return fishBuilders.Fish;
        }

        public static Fish Create(FishType fishType)
        {
            switch (fishType)
            {
                case FishType.Rockfish:
                    return CreateCore(new RockfishBuilder());
                case FishType.Flatfish:
                    return CreateCore(new FlatfishBuilder());
                case FishType.Squid:
                    return CreateCore(new SquidBuilder());
                case FishType.SeaBream:
                    return CreateCore(new SeaBreamBuilder());
                case FishType.Salmon:
                    return CreateCore(new SalmonBuilder());
                case FishType.Carp:
                    return CreateCore(new CarpBuilder());
                case FishType.Goldfish:
                    return CreateCore(new GoldfishBuilder());
                case FishType.SeaTurtle:
                    return CreateCore(new SeaTurtleBuilder());
                case FishType.Sunfish:
                    return CreateCore(new SunfishBuilder());
                case FishType.Dolphin:
                    return CreateCore(new DolphinBuilder());
                default:
                    throw new NotImplementedException("Factory.Create");

            }
        }

    }

    public enum FishType
    {
        Rockfish,
        Flatfish,
        Squid,
        SeaBream,
        Salmon,
        Carp,
        Goldfish,
        SeaTurtle,
        Sunfish,
        Dolphin
    }
}
