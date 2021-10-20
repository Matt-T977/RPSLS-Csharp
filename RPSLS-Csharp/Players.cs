using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    class Players
    {
        public string name;
        public int score;
        public List<string> gestures = new List<string>();
        public string choice;

        public Players(string name)
        {
            this.name = name;
            this.score = 0;
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
            this.choice = "";
        }


        public virtual string PickGesture()
        {
            bool invalid = true;

            while (invalid)
            {
                Console.WriteLine("\nRock | Paper | Scissors | Lizard | Spock\n" +
                    $"{name} please pick a gesture:\n");
                choice = Console.ReadLine().ToLower();
                if (GestureValidation())
                {
                    invalid = false;
                    return choice;
                }
            }
            return "Something went wrong. Check PickGesture.";
        }

        public bool GestureValidation()
        {
            bool valid = gestures.Any(choice.Contains);
            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
