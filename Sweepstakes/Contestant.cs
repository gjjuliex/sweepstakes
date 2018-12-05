using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public Guid regisNumber;

        public Contestant()
        {
            firstName = UserInterface.GetContestantFirstName();
            lastName = UserInterface.GetContestantLastName();
            email= UserInterface.GetContestantEmail();
            regisNumber = UserInterface.SetRegisNumber();
        }
    }
}
