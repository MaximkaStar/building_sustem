using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public abstract class Parts : IParts
    {
        public abstract bool CanBeLocated(Home home);
        public bool Located { get; set; }
        public Parts()
        {
            Located = false;
        }
    }
    
}
