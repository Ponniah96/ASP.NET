using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class Events
    {
        public void defintion()
        {
            Console.WriteLine("Events is used to notify or calls or triggers methods from one class to another class something going to happen");
            Console.WriteLine("Events are technically encapsulated delegate");
            Console.WriteLine("Publisher - Events are going to send or triggers");
            Console.WriteLine("Subscribers - Events are to receive or handle");
            Console.WriteLine();
            Console.WriteLine("Syntax:");
            Console.WriteLine("1.Passing Empty values");
            Console.WriteLine("Public event Eventhandler OnCreated()");
            Console.WriteLine("OnCreated(this, EventArgs.empty)");
            Console.WriteLine("Object+=SubscriberClass.Event");
            Console.WriteLine("public static void Send(object sender,EventRags e )");
            Console.WriteLine("2.Passing Values");
            Console.WriteLine("public event EventHandler<OrdeEventArgs> OnCreated");
            Console.WriteLine("public void(string email, int phone)");
            Console.WriteLine("OnCreated(this, new OrderEventArgs(Email=email, phone=phone)");
            Console.WriteLine("public static void Send(object sender, OrderEventArgs e)");
            Console.WriteLine();

            //Call Events and delegates
            Console.WriteLine("Display First Name, Last Name using Delegates"); 
            var publisherClass = new PublisherClass();
            publisherClass.CallEvent += SubscriberClass1.displayFirstName;
            publisherClass.CallEvent += SubscriberClass2.displayLastName;
            publisherClass.CallMethod();
        }

        //Basic Event Example to display first name and alast Name

        class PublisherClass {
            public event EventHandler CallEvent;

            public void CallMethod()
            {
                Console.WriteLine("Call Method triggers");
                if(CallEvent  != null)
                {
                    CallEvent(this, EventArgs.Empty);
                }
            }
        }

        class SubscriberClass1
        {
            public static void displayFirstName(object sender, EventArgs e) { Console.WriteLine("First Name: Ponniah"); }
        }

        class SubscriberClass2
        {
            public static void displayLastName(object sender, EventArgs e) { Console.WriteLine("Last Name: Kotandaraman"); }
        }
    }
}
