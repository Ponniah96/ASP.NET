using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPDotNETCoreWebAPITutorials
{
    internal class HttpBasics
    {
        public void definition()
        {
            Console.WriteLine("HTTP Basics");
            Console.WriteLine("HTTP stands for HyperText Transfer Protocol. It is an application layer protocol which exchanges data between server and clients(web browsers, mobile,iOs)");
            Console.WriteLine();
            Console.WriteLine("Adavantages of HTTP");
            Console.WriteLine("1.Web Development");
            Console.WriteLine("2.Web browsers");
            Console.WriteLine("3.Security");
            Console.WriteLine("4.API integration");
            Console.WriteLine("5.");
            Console.WriteLine();
            Console.WriteLine("HTTP Request - Resposne Model");
            Console.WriteLine("HTTP Request: Http Request is an request that sends from clients to servers");
            Console.WriteLine("HTTP request comonents:");
            Console.WriteLine("1.URL: Host, User agent, Content type, Authorisation");
            Console.WriteLine("2.Verb");
            Console.WriteLine("3.Headers");
            Console.WriteLine("4.Body");
            Console.WriteLine("HTTP Response components");
            Console.WriteLine("1.URL");
            Console.WriteLine("2.Headers - URL, Status code, status response");
            Console.WriteLine("3.Body");
            Console.WriteLine();
            Console.WriteLine("HTTP Methods");
            Console.WriteLine("1.GET: Get method is used to retrieve the data from database");
            Console.WriteLine("2.POST: Post method is used to create new entry in database resources");
            Console.WriteLine("3.PUT: Put method is used to update existing records in database resources");
            Console.WriteLine("4.PATCH: Patch method is used to update specific reords or columns in existing resource");
            Console.WriteLine("5.DELETE: Delete method is used to delete records in database");
            Console.WriteLine("5.1.SOFT DELETE: Soft delete is used when we update specific record in column (i.e: isDeleted)");
            Console.WriteLine("5.2.Hard Delete: Hard delete is used to existing record in a database");
            Console.WriteLine("6.Head: Head method is used to get head communication resource of the database");
            Console.WriteLine("7.Options: Options method is used to get communication avalibale options for the resource");
            Console.WriteLine();
            Console.WriteLine("HTTP Status Code");
            Console.WriteLine("HTTP Status Code are the information or message we are getting from server based on our request from client");
            Console.WriteLine("Common terminology in HTTP Status Code:");
            Console.WriteLine("1.1XX - Information Resource");
            Console.WriteLine("2.2XX - Successful Resposne");
            Console.WriteLine("3.3XX - Redirectional Response");
            Console.WriteLine("4.4XX - Bad Request Response");
            Console.WriteLine("5.5XX - Server Error Resposne");
            Console.WriteLine("Most Commonly used HTTP Status Code");
            Console.WriteLine("1.100 - Continue Response");
            Console.WriteLine("2.200 - OK Response - Success response from server");
            Console.WriteLine("3.201 - New Response Created - POST Method");
            Console.WriteLine("4.203 - No Content Response");
            Console.WriteLine("5.301 - Means Redirectional Response - Permamantly moved resource to response headers");
            Console.WriteLine("6.303 - Means Found Response - Temporarily moved resource to response headers");
            Console.WriteLine("7.400 - Means Bad Request");
            Console.WriteLine("8.401 - Means Unauthorised Request");
            Console.WriteLine("9.403 - Means Forbidden - Access there but don't have permission to use methods");
            Console.WriteLine("10.404- Means Resource not found");
            Console.WriteLine("11.405- Means Method not found in server");
            Console.WriteLine("12.500- Means Server Error");
            Console.WriteLine("13.501- Means Server unavailable");
            Console.WriteLine("14.503- Means Server timeout");
        }
    }
}
