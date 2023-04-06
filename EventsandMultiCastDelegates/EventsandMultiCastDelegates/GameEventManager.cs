using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandMultiCastDelegates
{
    internal class GameEventManager
    {
        public delegate void GameEvent();

        //event keyword makes it so that an event is required to be triggered. Check Player class and notice we must use =+ and not =
        public static event GameEvent OnGameStart, OnGameOver;

        //a static method to trigger when the game starts
        public static void TriggerGameStart()
        {
            //Check if the OnGameStart event is not empty
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started...");
                //Call OnGameStart to trigger all methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if(OnGameOver != null)
            {
                Console.WriteLine("The game is over...");
                //Call OnGameStart to trigger all methods subscribed to this event
                OnGameOver();

            }
        }

    }
}
