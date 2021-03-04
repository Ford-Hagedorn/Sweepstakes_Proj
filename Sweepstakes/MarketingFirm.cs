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

        }
    }
}
