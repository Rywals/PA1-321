using System;

namespace PA1_321
{
    public class Menu
    {
        public static string MainMenu()
        {
            Console.WriteLine("Welcome to Big Al's Music Playlist! Choose from the following menu options. \n1 - Show all songs \n2 - Add a song \n3 - Delete a song \n4 - Exit");
            string temp = Console.ReadLine();
            return temp;
        }
    }
}