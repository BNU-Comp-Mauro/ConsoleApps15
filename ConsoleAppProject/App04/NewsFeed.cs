using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal.
    ///</summary>
    ///<author>
    ///  Mauro Duarte Nunes
    ///  21815118
    ///  22.04.2021
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Mauro Nunes";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "Hello Jupiter");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Soup");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Prompts the creation of a message post to post on the feed.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Prompts the creation of a photo post to post on the feed.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal.
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }
}
