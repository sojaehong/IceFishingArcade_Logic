using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic
{
    class Aquarium
    {
        #region
        private static Aquarium _instance;

        public static Aquarium Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Aquarium();
                }

                return _instance;
            }
        }

        public Aquarium() { }
        #endregion

        public List<Fish> Fishs { get; set; }


    }
}
