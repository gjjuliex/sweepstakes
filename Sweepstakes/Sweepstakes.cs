using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {


        public void RegisterContestant(Contestant contestant)
        {
            UserInterface ui = new UserInterface();
            contestant = ui.AssignContestant(contestant);

        }
    }
}
