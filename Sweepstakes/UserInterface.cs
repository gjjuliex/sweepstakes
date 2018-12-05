using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            Console.Write("Please Enter Selection:   ");


            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string GetContestantFirstName()
        {
            string userInput = GetUserInput("Enter your first name: ");
            return userInput;
        }
        public static string GetContestantLastName()
        {
            string userInput = GetUserInput("Enter your last name: ");
            return userInput;
        }
        public static string GetContestantEmail()
        {
            string userInput = GetUserInput("Enter your email address: ");
            return userInput;
        }
        public static Guid SetRegisNumber()
        {
            Guid newGuid;
            newGuid = Guid.NewGuid();
            return newGuid;
        }
        public static string GetManagerType()
        {
            string managerType = GetUserInput("Select Required Manager:\n[1] Stack Manager\n[2] Queue Manager");
            return managerType;
        }
        public static Sweepstakes CreateSweepstake()
        {
            Sweepstakes newSweepstake = new Sweepstakes();
            return newSweepstake;
        }
        public static string DoneAddingContestants()
        {
            string userInput = GetUserInput("Would you like to add more contestants? [yes] [no] ");
            return userInput;
        }
        public static string DetermineSweepstakeAction()
        {
            string userInput = GetUserInput("What would you like to do?\n[1] Add Contestants\n[2] View Contestants\n[3] Determine Winner\n[4] Exit");
            return userInput;
        }
        public static string DetermineMarketingFirmAction()
        {
            string userInput = GetUserInput("What would you like to do?\n[1] Get Sweepstake\n[2] Insert Sweepstake\n[3] Change Manager Type\n[4] Exit Application");
            return userInput;
        }
    }
}
