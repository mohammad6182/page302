using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page302
{
    class Employee : Person, IQuittable
    {
        public override void FirstName()
        {
            Console.WriteLine("SayNAme is : ");
            Console.ReadLine();
        }
        public void Quit(Employee employee)
        {

        }

    }

    

    
}
