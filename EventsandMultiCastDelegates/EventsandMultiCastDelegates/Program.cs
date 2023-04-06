namespace EventsandMultiCastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an audio system
            AudioSystem audioSystem = new AudioSystem();
            //Create a rendering Engine
            RenderingEngine renderingEngine = new RenderingEngine();
            //Create two players and give them ID's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            //Start game
            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running... Press any key to end the game.");

            //pause
            Console.Read();

            //Game is over
            GameEventManager.TriggerGameOver();

            Console.WriteLine("The game has ended");

        }
    }
}