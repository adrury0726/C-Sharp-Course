
/* CHALLENGE: Add a deriving Class "VideoPost" with a property VideoURL, Length
 * Create the required constructors to create a VideoPost
 * Adjust the ToString() method accordingly
 * Create an instance of VideoPost
 * Use timer and a callback method 
 * create fields as required
 * Add member methods "Play" which should write the current duration of the video
 * Add "Stop" which should stop the "timer" and write "stopped at {0} seconds". 
 * Play the video after creating the instance and pause it, when the user presses any key.
 * */


namespace MoreInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes!", true, "Aaron Drury");
            Console.WriteLine(post1.ToString());
            Console.ReadLine();
            ImagePost imagePost1 = new ImagePost("Check out my new shoes!", "Aaron Drury", "https://images.com/shoes", true);

            VideoPost videoPost1 = new VideoPost("FailVideo", "Aaron Drury", "https://fakevideo.com/failvideo", true, 10);


            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video.");

            //Stop playing the video once a key is pressed by the user
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine();
        }


    }
}