using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPDotNETCoreWebAPITutorials
{
    internal class Basics
    {
        public void definition() 
        {
            Console.WriteLine("REST definition");
            Console.WriteLine("REST stands for  REpresentational State Transfer is a architechutural style for designing network applications.");
            Console.WriteLine("REST provides scalability and standard development mode of web services");
            Console.WriteLine();
            Console.WriteLine("Key Prinicle of REST");
            Console.WriteLine("1.Client-Server");
            Console.WriteLine("2.Stateless: Server doesn't store any client state information");
            Console.WriteLine("3.Uniform Resource: HTTP Methods(GET, PUT, POST, DELETE) and uniform URI should use for API");
            Console.WriteLine("4.Caching: HTTP Caching mechanism - Client cahce resource data while getting response");
            Console.WriteLine("5.layered Sysytem");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("RESTful Web API:");
            Console.WriteLine("RESTful Web API is stick to adhere principles of REST API. It helps to develop standard, scalable API.");
            Console.WriteLine();
            Console.WriteLine("Fundamental principles of RESTful API:");
            Console.WriteLine("1.Use HTTP verbs: (Get, Post, Put, Patch)");
            Console.WriteLine("2.Resource Oriented Genarator: uniform URI");
            Console.WriteLine("3.Use HTTP Coes: 200, 201, 400, 500");
            Console.WriteLine("4.Versioning"); ;
            Console.WriteLine("5.Input validation");
            Console.WriteLine("6.Error Handling");
            Console.WriteLine("7.Authentication and Authorisation");
            Console.WriteLine("8.Testing and validation");
            Console.WriteLine("9.Performance and scalablity: Caching, pagination");
            Console.WriteLine("10.Documentation");

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Requirements of Web API");
            Console.WriteLine("Disadvantages of Without Web API");
            Console.WriteLine("1.Duplicate of code");
            Console.WriteLine("2.More Chances of error");
            Console.WriteLine("3.Front end frameworks cannot communicate directly into DB");
            Console.WriteLine("4.Difficult to manintain");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What is WEB API");
            Console.WriteLine("Web API is an interface which is used to communicate or exchange data from server to clients. It receives HTTP request and responds it with appropiate HTTP response");
            Console.WriteLine("Web API is based on the principle of REST. Stateless, URI use HTTP standared Verbs");
            Console.WriteLine("Web API is a concept that works on http protocol which is used as bridge to connect DB with front end frameworks using ASP.NET technology");
            Console.WriteLine();
            Console.WriteLine("Features of Web API:");
            Console.WriteLine("1.Server-client communication");
            Console.WriteLine("2.Cross platform compatibility") ;
            Console.WriteLine("3.Mobile based Application"); 
            Console.WriteLine("4.Web Application") ;
            Console.WriteLine("5.iOs Application") ;
            Console.WriteLine("6.Third party integration") ;
            Console.WriteLine("7.Service integration") ;
            Console.WriteLine("8.Microservices architechture") ;
            Console.WriteLine();
            Console.WriteLine("Advantages");
            Console.WriteLine("1.Single Code for all applications");
            Console.WriteLine("2.Extend application functionality based on requirements");
            Console.WriteLine("3.Security: Since front end cannot able to direclty acess to DB, it gives security to Db from hackers");
            Console.WriteLine("4.Abstraction: Web API helps to abstract data from front end");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ASP.NET Core Web API");
            Console.WriteLine("ASP.Net Core Web API provides rich, robust, standardd, scalable, flexible for Web API development.");
            Console.WriteLine();
            Console.WriteLine("Advantages of ASP.NET Core Web API");
            Console.WriteLine("1.Mainimal API");
            Console.WriteLine("2.HTTP# support");
            Console.WriteLine("3.Open API improvements");
            Console.WriteLine("4.Web Socket IO standard");
            Console.WriteLine("5.gRPC improvements");
            Console.WriteLine("6.HealthChecks");
            Console.WriteLine("7.JSON Serialiser enhancements") ;
        }
    }
}
