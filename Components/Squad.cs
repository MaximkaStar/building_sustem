using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Squad
    {
        List<Workman> Workmans { get; set; }
        TeamLeader Boss { get; set; }
        public Squad(int sumOfWorkmans = 0)
        {
            Workmans = new List<Workman>)();
            Boss = new TeamLeader();
            for (int j= 0 , j < sumOfWorkmans; j++)
            {
                Workmans.Add(new Workman());
            }
        }

        public int GetSumOfWorkmans()
        {
            return Workmans.Count;
        }
        public void UseBoss(Home home)
        {
            Boss.MakeWork(home);
        }
        public void UseOneWorkman(Home home)
        {
            Workmans[Workmans.Sum - 1].MakeWork(home);
            Workmans.Remove(Workmans[Workmans.Sum - 1]);
        }





        public void UseTeamLeader(global::BuldingSystem.Home home)
        {
            if (home == null)
            {
                throw new ArgumentNullException(nameof(home));
            }

            throw new NotImplementedException();
        }

        public void UseTeamLeader(global::BuldingSystem.Home home)
        {
            throw new NotImplementedException();
        }

        public void UseOneWorkman(global::BuldingSystem.Home home)
        {
            throw new NotImplementedException();
        }

        public void UseOneWorkman(global::BuldingSystem.Home home)
        {
            throw new NotImplementedException();
        }

        

    }
}
