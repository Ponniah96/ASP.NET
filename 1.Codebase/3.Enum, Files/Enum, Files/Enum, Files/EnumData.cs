using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum__Files
{
    internal class EnumData
    {
        public int enumvalue;
        enum piValue
        {
            Age = 26
        }

        public void DisplayEnumvalue()
        {
            enumvalue = (int)piValue.Age;
        }
    }
}
