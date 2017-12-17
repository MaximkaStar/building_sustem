using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Door : Parts
    {
        public Door() : base()
        {
            isLocated = false;
        }
        public override bool CanBeLocated(Home home)
        {
            if (home.Walls[3].Located && !home.Door.Located)
            {
                return true;
            }
            return false;
        }

        public static implicit operator List<object>(Door v)
        {
            throw new NotImplementedException();
        }
    }
}
