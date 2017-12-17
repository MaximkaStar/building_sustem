using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Carpet : Parts
    {
        public override bool CanBeLocated(Home home)
        {
            if (home.Windows[home.Windows.Capacity-1].Located && !home.Carpet.Located)
            {
                return true;
            }
            return false;
        }
    }
}
