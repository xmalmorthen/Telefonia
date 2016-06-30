using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellTrack.Classes
{
    public static class modemStatus
    {
        private static Boolean free;
        public static Boolean Free
        {
            get { return modemStatus.free; }
        }

        public static void Occupied() {
            free = false;
        }

        public static void Vacant()
        {
            free = true;
        }

    }
}
