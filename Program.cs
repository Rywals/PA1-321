using System;
using System.Collections.Generic;

namespace PA1_321
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> song = SongFile.GetSongs();

            string mainMenu = Menu.MainMenu();

            while(mainMenu != "4")
            {   
                if(mainMenu == "1")
                {
                    song.Sort();
                    SongUtil.PrintAllSongs(song);
                }
                else if(mainMenu == "2")
                {
                   SongUtil.AddSong(song); 
                   SongFile.AddSong(song);
                }
                else if(mainMenu == "3")
                {
                    SongUtil.DeleteSong(song);
                    SongFile.UpdateSong(song);
                }

                mainMenu = Menu.MainMenu();
            }
        }
    }
}
