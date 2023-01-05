using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool CanPopWheelie { get; set; }
        public bool HasSideCar { get; set; }    

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle zooms!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }
    }
}
