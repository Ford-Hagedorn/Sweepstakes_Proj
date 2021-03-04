using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        
        public MarketingFirm()
        {
            

        }
        public void ChooseManager(string choice)
        {
            switch (choice)
            {
                case "1":
                    manager = new StackManager();
                    break;

                case "2":
                    manager = new QueueManager();
                    break;
                default:
                    throw new ApplicationException(string.Format("Sorry, that's not a" +
                        "valid choice."));

            }
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            Console.WriteLine("Welcome to our sweepstakes! It's completely free to enter!" +
                "All you have to do is give us your name (first and last), and a valid email address" +
                "and we will send you a registration number! Once you have that number, that's it!" +
                "You're entered into the contest! The grand prize for this sweepstakes?" +
                "A brand new Vespa, custom fitted with a sweet Roll Cage! It's a one-of-a-kind prize," +
                "so enter soon and maybe you'll be the lucky winner!");

        }
    }
}
