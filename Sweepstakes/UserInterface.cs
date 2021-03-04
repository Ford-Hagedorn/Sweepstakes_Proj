using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        
        public static string GetContestantName()
        {

            Console.WriteLine($"Welcome! Please enter your name!");
            string userInputName = Console.ReadLine();
            return userInputName;




        }

        
    }
}
