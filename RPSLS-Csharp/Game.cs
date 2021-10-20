using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    class Game
    {
        int roundCount;
        int maxRounds;
        int mode;
        WinConditions winConditions = new WinConditions();



        public Game()
        {
            this.roundCount = 0;
            this.maxRounds = 0;
            this.mode = 0;
            RunGame();
        }


        public void RunGame()
        {
            DisplayRules();
            GameMode();
            GeneratePlayers();
            RoundCountOption();
            StartRound();
            DisplayWinner();
        }


        public void DisplayRules()
        {
            RulesArt ruleArt = new RulesArt();
            Console.WriteLine(ruleArt.rulesArt);
        }

        public void GeneratePlayers()
        {
            PlayerList playerList = new PlayerList();
            playerList.CreatePlayers(mode);
        }

        public void GameMode()
        {
            Console.WriteLine("" +
                "Select a game mode: \n" +
                "1 - Single Player \n" +
                "2 - MultiPlayer");
            mode = Convert.ToInt32(Console.ReadLine());
        }

        public void RoundCountOption()
        {
            Console.WriteLine("Enter the number of rounds you'd like to play:\n");
            roundCount = Convert.ToInt32(Console.ReadLine());
            winConditions.HowManyWins(roundCount);
        }

        public void StartRound()
        {
            bool gameContinue = true;

            int currentRound = 1;
            while (gameContinue) ;
            {
                Console.WriteLine("____________________________________________________________");
                Console.WriteLine($"Round: {currentRound}/{roundCount}");
                GestureSelection();
                RoundResult();
                DisplayScore();
                currentRound += 1;
                gameContinue = winCoditions.WinConditionCheck();
            }
        }

        public void GestureSelection()
        {
            Console.WriteLine("Pick Gesture Call");
        }

        public void RoundResult()
        {
            bool playerOneResult = true;
            if (playerOneResult)
            {
                Console.WriteLine("Increase Player One Score");
            }
            else if (playerOneResult == false)
            {
                Console.WriteLine("Increase Player Two Score");
            }
            else
            {
                Console.WriteLine("\n This round is a Draw! \n");
            }
        }
        
        public void DisplayScore()
        {
            Console.WriteLine("Player One Score: | Player Two Score:");
        }

        public void DisplayWinner()
        {
            Console.WriteLine("Display the winner");
        }
    }
}
