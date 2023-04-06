using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMultiCastDelegates
{
    public class RenderingEngine
    {
        //Constructor
        public RenderingEngine()
        {
            //Subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //At start of game, enable the rendering engine and start drawing visual effects
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals......");
        }

        //When the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }

    }
}
