using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        private PhotoPost photo;
        private MessagePost message;

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("     Mauro's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            news.AddPhotoPost(photo);
        }

        private void PostMessage()
        {
            news.AddMessagePost(message);
        }
    }
}
