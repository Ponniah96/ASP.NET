// See https://aka.ms/new-console-template for more information


using ASPDotNETCoreWebAPITutorials;


Console.WriteLine("Welcome to ASP.Net Core Web API Basics");
Console.WriteLine();
Console.WriteLine();

Basics basics = new Basics();
basics.definition();


Console.WriteLine();
Console.WriteLine();


HttpBasics httpBasics = new HttpBasics();
httpBasics.definition();