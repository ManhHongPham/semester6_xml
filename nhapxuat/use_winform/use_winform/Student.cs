using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_winform
{
    class Student
    {
        public string sid { get; set; }

        public string name { get; set; }

        public string age { get; set; }
        public string address { get; set; }

        public Student()
        {

        }
        public Student(string sid)
        {
            this.sid = sid;
        }
        
        
    }
}
