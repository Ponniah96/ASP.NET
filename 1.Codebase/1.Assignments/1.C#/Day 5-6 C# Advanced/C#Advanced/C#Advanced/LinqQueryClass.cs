using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace C_Advanced
{
    internal class LinqQueryClass
    {
        public void readCSVData()
        {
            //Get FilePath
            string path = "D:/Learning/5. ASP.Net/1.CodeBase/Assignments/C#/Day 5-6 C# Advanced/C#Advanced/biostats.csv";
            string[] lines = System.IO.File.ReadAllLines(path);


            //Create List And store csv data
            List<string> fileData = new List<string>(lines);

            List<EmployeeData> employees = new List<EmployeeData>();

            EmployeeData employee = new EmployeeData();

            /* foreach (string line in fileData)
             {
                 Console.WriteLine(line);
                 string[] columns = line.Split(',');
                 *//*foreach (string column in columns)
                 {
                     employees.Add(
                         new EmployeeData()
                         {
                             Name = column[0],
                             Age = 
                         }); 
                 }*//*
                 for(var i=0;i<columns.Length; i++)
                 {
                     employees.Add(
                          new EmployeeData()
                          {
                              Name = columns[0],
                              Sex = columns[1],
                              Age = Convert.ToInt32(columns[2]),
                              Height = columns[4],
                              Weight = columns[5]                          

                          }
                    );
                 }
             }*/
            
            /*for (var j=1;j< fileData.Count; j++)
            {
                string Names, Sex;
                int Age, Height, Weight;
                string[] columns = fileData[j].Split(',');                
                for (var i = 0; i < columns.Length; i++)
                {
                    if (i==0) { Names = columns[i]; }
                    else if (i==1) { Sex = columns[i]; }
                    else if (i==2) { Age = Convert.ToInt32(columns[i]); }
                    else if (i==3) { Height = Convert.ToInt32(columns[i]); }
                    else if (i==4 && i==(columns.Length-1)) { Weight = Convert.ToInt32(columns[i]);}
                }
                if (Names && Sex !== null && Age !== null && Height !== null && Weight !== null)
                {
                    employee.PassData(Names, Sex, Age, Height, Weight);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }*/

            Console.WriteLine($"Employee Data Count: {employees.Count}");

            
        }

    }

    public class EmployeeData
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int Age { get; set; }

        /*public static EmployeeData PassData(string a, string b, int c, int d, int e) { 
            Console.WriteLine(a,b,c,d,e);
        }*/
    }
}
