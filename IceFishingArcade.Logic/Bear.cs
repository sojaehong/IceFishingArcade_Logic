using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceFishingArcade.Logic
{
    class Bear
    {
        #region
        private static Bear _instance;

        public static Bear Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bear();

                return _instance;
            }
        }

        public Bear() { }
        #endregion


    }
}
