using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public string name { get; set; }
        public string zachet { get; set; }
        public override string ToString()
        {
            return string.Format("{0}-{1}", name, zachet);

        }
    }
}

