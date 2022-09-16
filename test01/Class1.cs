using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
     class Gebaeude
    {
        string Name;
        public string NameAccessible
        {
            get { return Name; }
            set { Name = value; }
        }
    }
}
