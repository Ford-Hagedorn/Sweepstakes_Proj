using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public Random random;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;
        public void CreateContestant()
        {
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            EmailAddress = Console.ReadLine();
            GenerateRegistrationNumber();
            RegistrationNumber = Console.WriteLine($"Your registration number is {newRegNumber}");

        }
        public void GenerateRegistrationNumber()
        {
            random = new Random();
            int newRegNumber = random.Next(0, newRegNumber);
            
        }
    }
}
