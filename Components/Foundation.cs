using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Foundation : Parts
    {
        public Foundation() : base()
        {
            Located = false;
        }
        public override bool CanBeLocated(Home home)
        {
            if(Home.Foundation.isLocated == false)
            {
                return true;
            }
            return false;
        }
      

    }
}
