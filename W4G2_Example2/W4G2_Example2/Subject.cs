using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G2_Example2
{
    [Serializable]
    public class Subject
    {
        public string name;
        public Subject() { }
        public Subject(string name)
        {
            this.name = name;
        }
    }
}
