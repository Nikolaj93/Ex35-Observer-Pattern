using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Observer_Pattern
{
    public class Student
    {
        private Academy subject;

        public string Message;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public Student(Academy subject, string Name)
        {

        }
        public void Update()
        {
        }
    }
}
