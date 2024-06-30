using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeCSharp
{
    internal class Roles
    {
        public string ASE = "Prodapt Solutions";
        public string SSE = "I-Exceed Technology Solutions";
        public string AAIII = "Devon";

        public void DisplayCompanyName()
        {
            Roles firstCompany = new Roles();
            Console.WriteLine($"My First Company: {firstCompany.ASE}");
        }

    }
}
