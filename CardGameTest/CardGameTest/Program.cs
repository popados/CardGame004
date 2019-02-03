using System;

namespace CardGameTest
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();

        }
    }
}

// LIFECYCLE >> init > loadContent > unloadContent > update > draw
//~~~TODO FOR THE CARD GAME~~~//
//User Interface []
//Text Options []
//Menu Options []
//Display Card Class Objects[]
//Create deck menu []
////
//Create Game States
//Enter/Exit game
//Enter Game State Contains:
//Display card []
//Display Deck []
//user select card[]
//play area []
//enemy AI[]
//
//
//Use buttons to move between gamestates
//each game state will be sprite text and sprites to display stuff
//XNA is used for forms
//card placeholder graphic []
//button to display card []
//list to select card []
