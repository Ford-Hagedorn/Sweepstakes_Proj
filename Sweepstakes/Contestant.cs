using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        string FirstName;
        string LastName;
        string EmailAddress;
        int RegistrationNumber;
        public void CreateContestant()
        {
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            EmailAddress = Console.ReadLine();

        }
        public void GenerateRegistrationNumber()
        {

        }
    }
}
