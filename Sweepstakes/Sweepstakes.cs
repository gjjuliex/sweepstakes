using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<Guid, Contestant> contestants = new Dictionary<Guid, Contestant>();
        public string sweepstakesName;
        private static Random randomNumber = new Random();
        Contestant contestant;
    }

  
}
