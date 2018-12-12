using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Observer_Pattern
{
    public class Academy
    {
        List<Student> students = new List<Student>();
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Message;

        public Academy(string Name)
        {

        }

        public void Attach(Student s1)
        {
            
        }

        public void Detach(Student s2)
        {
            
        }
    }
}
