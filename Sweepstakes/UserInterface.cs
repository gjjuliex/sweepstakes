using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {

        public UserInterface()
        {
           
    
        }

        public Contestant AssignContestant(Contestant contestant)
        {
            Console.Write("Name of constestant");
            contestant.firstName = Console.ReadLine();
            Console.Write("Last name of contestant");
            contestant.lastName = Console.ReadLine();
            Console.Write("Constestant's email");

            return contestant;

        }
    }
}
