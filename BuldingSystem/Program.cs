using Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuldingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            Squad squad = new Squad(home.EVERTHYNG_DETAIS);
            while (squad.GetSumOfWorkmans() > 0)
            {
                squad.UseOneWorkman(home);
            }
            squad.UseTeamLeader(home);
            Console.ReadLine();
            Console.Clear();
        }
    }

    internal class Home
    {
        public int EVERTHYNG_DETAIS { get; internal set; }
    }
}
