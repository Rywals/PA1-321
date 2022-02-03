using System;
using System.Collections.Generic;

namespace PA1_321
{
    public class SongUtil
    {
        public static List<Song> AddSong(List<Song> song)
        {
            Console.WriteLine("What is the title of the song?");
            string temp = Console.ReadLine();
            DateTime dt3 = DateTime.Now;
            song.Add(new Song(){ID = Song.count, Title = temp, dateTime = dt3, Delete = false});
            Song.IncCount();
            return song;
        }
        public static void PrintAllSongs(List<Song> song)
        {
            int count = 1;
            foreach(Song x in song)
            {
                if(x.Delete == false)
                {
                    Console.WriteLine((count)  + " - " + x.Title);
                    count++;
                }
               
            }
        } 
        public static List<Song> DeleteSong(List<Song> song)
        {
            Console.WriteLine("What song do you want to delete?");
            PrintAllSongs(song);
            int temp = 0;
            try
            {
                temp = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please make a valid selection");
            }
            foreach(Song a in song)
            {
                if(a.ID == temp + Song.deleteCount)
                {
                    a.Delete = true;
                }
            }

            return song;
        }
        
    }
}