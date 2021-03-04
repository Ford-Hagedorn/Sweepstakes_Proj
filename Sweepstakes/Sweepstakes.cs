using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
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
            
            random = new Random();
            int randomNumber = random.Next(0, contestants.Count);
            
            Console.WriteLine($"Congratulations {randomNumber}! You won!" +
                $"Your prize is a brand new Vespa with a Roll Cage!" +
                $"Enjoy!");
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant = PickWinner();
            Console.WriteLine($"The sweepstakes is over. A huge congratulations to" +
                $"{contestant.FirstName}{contestant.LastName}! We want to thank everyone" +
                $"who participated and wish everyone good luck in the next sweepstakes!");
        }

    }
}
