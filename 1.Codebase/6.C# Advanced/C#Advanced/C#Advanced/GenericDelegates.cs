using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class GenericDelegates
    {
        public void definition()
        {
            Console.WriteLine("Geneic delegates are the inbuild delegates in .NET Framework");
            Console.WriteLine();
            Console.WriteLine("Generic delegates methods");
            Console.WriteLine("1.Func");
            Console.WriteLine("2.Action");
            Console.WriteLine("3.Predicate");
            Console.WriteLine();


            FuncClass.funcDefinition();

            ActionClass.ActionDefinition();

            PredictiveClass.predictiveClassDefinition();
        }
    }

    //Func
    class FuncClass
    {
        public static void funcDefinition() 
        {
            Console.WriteLine("Func Delegate");
            Console.WriteLine("Func Delagte is a generic delegate which contains 0 to 16 parameters and output as 1 paramaters which is last");
            
            //Assign Func Delegate
            Func<int, int, int> obj = new Func<int, int, int>(Add);
            int Result = obj.Invoke(5, 6);
            Console.WriteLine($"Result of Func Delagate:{Result}");
            Console.WriteLine();
        }
        
        public static int Add (int x, int y)
        {
            return x + y;
        }
    }


    //Action
    class ActionClass
    {
        public static void ActionDefinition()
        {
            Console.WriteLine("Action Delegate");
            Console.WriteLine("Action Delagte is a generic delegate which contains 1 to 16 parameters and output as 0 paramaters ");

            //Assign Action Delegate
            Action<string, string> obj = new Action<string , string>(StringConcatenation);
            obj.Invoke("Ponniah", "Kothandaraman");

            Console.WriteLine();
        }

        public static void StringConcatenation(string x, string y)
        {
            Console.WriteLine($"Action Delagate Result: {x + y}");
        }
    }

    //Predictive Delegates
    class PredictiveClass
    {
        public static void predictiveClassDefinition()
        {
            Console.WriteLine("Predictive Delegate");
            Console.WriteLine("Predictive delegate is a generic delegate which contians 1 input parameter and 1 output paramater which is boolean");

            //Assign Predicitve Delgate
            Predicate<int> obj = new Predicate<int>(CheckEven);
            bool Result = obj.Invoke(5);
            Console.WriteLine($"Predictive Result: {Result}");
            Console.WriteLine();
        }

        public static bool CheckEven(int input)
        {
            if(input%2==0) 
                return true;
            return false;
        }
    }

}
