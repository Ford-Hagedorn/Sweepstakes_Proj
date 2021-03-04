using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get => name; set => name = value; }
        public Random random;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public Contestant PickWinner()
        {
            //Choose a random contestant as the big winner  
            random = new Random();
            int randomNumber = random.Next(0, contestants.registrationNumber.Count);
            Console.WriteLine($"Congratulations {randomNumber}! You won!" +
                $"Your prize is a brand new Vespa with a Roll Cage!" +
                $"Enjoy!");
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            
        }

    }
}
