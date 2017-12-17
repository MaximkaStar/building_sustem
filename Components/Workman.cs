using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Workman : IWorkman
    {
        string Name { get; set; }
        public int TOTAL_OF_WINDOWS { get; private set; }

        public Workman(string name = "Workman")
        {
            Name = name;
        }
        public void MakeWork(Home home)
        {
            if (!home.Foundation.Located)
            {
                home.Foundation.Located = true;
                return;
            }
            for (int i = 0; i<Home.TOTAL_OF_WALLS; i++)
            {
                if (!home.Walls[i].Located)
                {
                    home.Walls[i].Located = true;
                    return;
                }
                
            }
            if (!home.Door.Located)
            {
                home.Door.Located = true;
                return;
            }
            for (int j = 0; j < TOTAL_OF_WINDOWS; j++)
            {
                home.Windows[j].Located = true;
                return;
            }
            if(!home.Carpet.Located)
            {
                home.Carpet.Located = true;
                return;
            }
        }
    }
}
