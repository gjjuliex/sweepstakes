using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {

        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {

        }
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface ui = new UserInterface();
            contestant = ui.AssignContestant(contestant);
            contestant.registrationNumber = dictionary.Count + 1;
            dictionary.Add(contestant.registrationNumber, contestant);

        }
        public string PickWinner(Contestant contestant)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, dictionary.Count);
            if (randomNumber == contestant.registrationNumber)
            {
                
            }
            else
            {
                // PickWinner();
            }
            return "";
              
        }
        
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        
    }
}
