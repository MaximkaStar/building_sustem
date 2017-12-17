using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Walls : Parts
    {
        public Walls() : base()
        {
            Located = false;
        }
        public override bool CanBeLocated(Home home)
        {
            if (home.Foundation.Located && home.Walls.Sum < 4)
            {
                return true;
            }
            return false;
        }
    }
}
