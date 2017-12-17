using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class TeamLeader : IWorkman
    {
        public void MakeWork(Home home)
        {
            int doneDetails = 0;
            int Windows = 0;
            int Walls = 0;
            for (int i = 0; i < Home.TOTAL_OF_WALLS; i++)
            {
                if (home.Walls[i].Located)
                {
                    Walls++;
                    doneDetails++;
                }
            }
            for (int i = 0; i < Home.TOTAL_OF_WINDOWS; i++)
            {
                if (home.Windows[i].Located)
                {
                    Windows++;
                    doneDetails++;
                }
            }

            string line = home.Foundation.Located ? "installed" : "notinstalled";

            doneDetails += home.Carpet.Located ? 1 : 0;
            doneDetails += home.Walls.Located ? 1 : 0;
            doneDetails += home.Foundation.Located ? 1 : 0;

            Console.WriteLine("Foundation:{0},", line);
            Console.WriteLine("Installed {0} walls", Walls);
            Console.WriteLine("Installed {0} windows", Windows);
            line = home.Door.Located ? "installed" : "notinstalled";
            Console.WriteLine("Door: {0}", line);
            line = home.Carpet.Located ? "installed" : "notinstalled";
            Console.WriteLine("Carpet: {0}", line);

            if(doneDetails==Home.EVERYTHING_DETAILS)
            {
                Console.WriteLine("Home has been build.");
            }
        }
    }
}
