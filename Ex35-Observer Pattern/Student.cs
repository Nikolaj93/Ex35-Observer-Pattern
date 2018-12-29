using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_Observer_Pattern
{
    public class Student
    {
        private Academy academy;

        public string Message;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public Student(Academy _academy, string Name)
        {
            academy = _academy;
            _name = name;
        }
        public void Update()
        {
            Message = academy.Message;
            Console.WriteLine("Studerende " + Name + " fik nyhed " + Message + " fra akademiet " + academy.Name);
        }
    }
}
