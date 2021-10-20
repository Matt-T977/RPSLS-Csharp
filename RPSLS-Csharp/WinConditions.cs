using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    class WinConditions
    {
        int winsNeeded;
        

        public WinConditions()
        {
            this.winsNeeded = 0;

        }

        public bool GestureComparison(string playerOne, string playerTwo)
        {
            //if (playerOne == playerTwo)
            //{
            //    return "This is a Draw!"
            //}
            if (playerOne.choice == "rock")
            {
                if (playerTwo.choice == "scissors" || playerTwo.choice == "lizard")
                {
                    return true;
                }
                else if (playerTwo.choice == "paper" || playerTwo.choice == "spock")
                {
                    return false;
                }
            }
            else if (playerOne.choice == "paper")
            {
                if (playerTwo.choice == "rock" || playerTwo.choice == "spock")
                {
                    return true;
                }
                else if (playerTwo.choice == "scissors" || playerTwo.choice == "lizard")
                {
                    return false;
                }
            }
            else if (playerOne.choice == "scissors")
            {
                if (playerTwo.choice == "paper" || playerTwo.choice == "lizard")
                {
                    return true;
                }
                else if (playerTwo.choice == "rock" || playerTwo.choice == "spock")
                {
                    return false;
                }
            }
            else if (playerOne.choice == "lizard")
            {
                if (playerTwo.choice == "spock" || playerTwo.choice == "paper")
                {
                    return true;
                }
                else if (playerTwo.choice == "rock" || playerTwo.choice == "scissors")
                {
                    return false;
                }
            }
            else if (playerOne.choice == "spock")
            {
                if (playerTwo.choice == "scissors" || playerTwo.choice == "rock")
                {
                    return true;
                }
                else if (playerTwo.choice == "lizard" or playerTwo.choice == "paper")
                {
                    return false;
                }
            }
        }

        public void HowManyWins(int rounds)
        {
            winsNeeded = (rounds / 2) + 1;
        }

        public bool WinConditionCheck()
        {
            //Check win condition
            return true;
        }
    }
}
