using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Observer_Pattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        public int state = 0;
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public ConcreteObserver(ConcreteSubject sub)
        {
            subject = sub;
        }
        public void Student(ConcreteSubject subject)
        {
            
        }

        public override void Update()
        {
            State = subject.State;
        }
    }
}
