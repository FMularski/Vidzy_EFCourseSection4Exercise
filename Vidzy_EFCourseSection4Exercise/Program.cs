using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_EFCourseSection4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MercuryContext();

            foreach( var video in context.Videos)
            {
                Console.WriteLine();
            }
        }
    }
}
