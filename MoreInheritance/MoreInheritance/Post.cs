using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInheritance
{
    class Post
    {
        private static int currentPostID;

        //Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        public bool IsPublic { get; set; }

        //These are our default values if information isn't filled out elsewhere
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Aaron Drury";
        }

        //Instance constructor that has 3 parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostID; //Implements by 1 each time it's called
        }

        public void Update(string title, bool isPublic) //Only allowing user to update the title and if it's public or not
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }

    }
}
