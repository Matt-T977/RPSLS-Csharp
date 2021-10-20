using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    class PlayerList
    {
        public Players [] players = new Players[2];


        public void CreatePlayers(int mode)
        {
            if (mode == 1)
            {
                Players playerOne = new Players("Player One");
                AI playerAI = new AI("Player Two");
                players[0] = playerOne;
                players[1] = playerAI;
            }

            else if (mode == 2)
            {
                Players playerOne = new Players("Player One");
                Players playerTwo = new Players("Player Two");
                players[0] = playerOne;
                players[1] = playerTwo;
            }
        }
    }
}
