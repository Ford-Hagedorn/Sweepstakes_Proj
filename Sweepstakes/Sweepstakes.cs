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

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        Contestant PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            
        }

    }
}
