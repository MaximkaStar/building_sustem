using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class Home
    {
        public const int TOTAL_OF_WINDOWS = 4;
        public const int TOTAL_OF_WALLS = 4;
        public const int EVERYTHING_DETAILS = 11;

        public List<Walls> Walls { get; set; }
        public List<Carpet> Carpet { get; set; }
        public List<Foundation> Foundation { get; set; }

        public List<Windows> Windows { get; set; }
        public List<Door> Door { get; set; }


        public Home()
        {
            Door = new Door();
            Carpet = new Carpet();
            Foundation = new Foundation();

            Windows = new List<Windows>
            {
                new Window(),
                new Window(),
                new Window(),
                new Window()
            };
            Walls = new List<Walls>
            {
                new Walls(),
                new Walls(),
                new Walls(),
                new Walls(),

            };

        }
    }
}
