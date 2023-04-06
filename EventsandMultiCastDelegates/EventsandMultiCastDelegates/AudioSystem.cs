using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMultiCastDelegates
{
    public class AudioSystem
    {
        //Constructor
        public AudioSystem()
        {
            //Subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }


        //At start of game, enable the audio system and start playing audio clips
        private void StartGame()
        {
            Console.WriteLine("Audio System Started....");
            Console.WriteLine("Playing Audio....");
        }
        //When the game is over, we want to stop the audio system
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
