using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory
    {
        public ISweepstakesManager DetermineManager(string manager)
        {
            switch (manager)
            {
                case "1":
                    return new SweepstakesQueueMananger();
                case "2":
                    return new SweepstakesStackMananger();
                default:
                    return DetermineManager(manager);
            }
        }
    }
}
