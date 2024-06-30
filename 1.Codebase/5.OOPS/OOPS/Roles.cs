using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Roles
    {
        //Fields
        public string ASE = "Prodapt Solutions";
        public string SSE = "I-Exceed Technology Solutions";
        public string AAIII = "Devon";
        public int ASEYear, SSEYear, AAIIIYear;
        private string aSE1stSalary;

        //Properties
        public string ASE1stSalary
        {
            get{ return aSE1stSalary; }
            set{ aSE1stSalary = value; }
        }

        //Constructor
        public Roles() { 
            ASEYear = 2018;
            SSEYear = 2021;
            AAIIIYear = 2023;
        }

        //Methods
        public void DisplayCompanyName()
        {
            Roles firstCompany = new Roles();
            Console.WriteLine($"My First Company: {firstCompany.ASE}");
        }

        public virtual void Display1stSalary()
        {
            Console.WriteLine("Display Salry based on roles");
        }


    }

    class Clients : Roles
    {
        public string ASEClients = "Windstream";
    }

    class ASEDisplaySalary : Roles
    {
        public override void Display1stSalary()
        {
            Console.WriteLine("ASE Salary: 19000");
        }
    }

    class SSEDisplaySalary : Roles
    {
        public override void Display1stSalary()
        {
            //base.Display1stSalary();
            Console.WriteLine("ASE Salary: 70000");
        }
    }
    class AAIIIDisplaySalary : Roles
    {
        public override void Display1stSalary()
        {
            //base.Display1stSalary();
            Console.WriteLine("ASE Salary: 125000");
        }
    }

    //Abstract Class & Abstarct Methods

    abstract class AbstractClass
    {
        public abstract void AbstractMethod();

        public void AbstractClassNormalMethod()
        {
            Console.WriteLine("Abstarct Class Normal method");
        }
    }

    class DerivedClass : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived Class Defining Abstract Method");
        }
    }

    interface InterfaceClass { 
        void InterfaceMethod();
    }

    class ImplementClass: InterfaceClass
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Implement Class Interface method");
        }
    }

    interface IMultipleInterface1
    {
        void MultipleInterfaceMethod1();
    }

    interface IMultipleInterface2
    {
        void MultipleInterfaceMethod2();
    }

    class ImplementMultipleClass: IMultipleInterface1, IMultipleInterface2
    {
        public void MultipleInterfaceMethod1()
        {
            Console.WriteLine("Interface 1 Method");
        }

        public void MultipleInterfaceMethod2() 
        {
            Console.WriteLine("Interface 2 Method");
        }
    }

    class ExistingClassForExtensionMethod
    {
        public int a = 100;

        public void Method1()
        {
            Console.WriteLine($"Extension Method Old Class Old method: {a}");
        }
    }

    static class NewClassForExtensionmethod
    {
        public static void Method2 (this ExistingClassForExtensionMethod e) {
            Console.WriteLine($"Extension Method New Class New Method: ");
        }
    }
}

