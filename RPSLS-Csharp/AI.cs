using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    class AI : Players
    {
        public AI (string name)
            :base(name)
        {
        }

        public override string PickGesture()
        {
            Random rnd = new Random();
            int choiceIndex = rnd.Next(gestures.Count);
            choice = gestures[choiceIndex];
            return choice;
        }
    }
}
