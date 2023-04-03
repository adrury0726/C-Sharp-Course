using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MoreInheritance
{
    class VideoPost : Post
    {
        //Member Fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;


        //Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;

            //Property VideoURL is a member of VideoPost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;

        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }

        private void TimerCallback(object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0} seconds", currDuration);
                GC.Collect(); //Cleans up garbage collection
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose(); //Stops the timer and resets it
            }

        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUserName);
        }

    }
}
