using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes test = new Sweepstakes("NEW CAR!");

            for(int i = 1; i < 3; i++)
            {
                Contestant newEntrant = new Contestant();
                test.RegisterContestant(newEntrant);
            }
        }
    }
}
