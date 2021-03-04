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
        public Contestant(string FirstName, string LastName, string EmailAddress, int randomUpperLimit)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            RegistrationNumber = random.Next(0, randomUpperLimit);
        

        }
        
    }
}
