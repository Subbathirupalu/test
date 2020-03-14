using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum level : byte
    {
        Beginner=1,
        Intermediate=2,
        Advanced=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new PlutoDbContext();
         
            var Courses = Context.GetCourses();
            foreach(var x in Courses)
            {
                Console.WriteLine(x.Title);
            }
            Console.ReadLine();
        }
    }
}
