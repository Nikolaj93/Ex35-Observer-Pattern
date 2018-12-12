using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Observer_Pattern
{
    public class ConcreteSubject : Subject
    {
        public int state = 0;

        public int State
        {
            get
            { return state;
            }
            set
            {
                state = value;
                Notify();
            }
        }
    }
}
