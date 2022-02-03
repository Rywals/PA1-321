using System;
using System.Collections.Generic;
using System.IO;

namespace PA1_321
{
    public class SongFile
    {
       public static List<Song> GetSongs()
       {
            List<Song> song = new List<Song>();

            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("songs.txt");
            }
            catch(FileNotFoundException e)
            {       
                Console.WriteLine("Can't find File" + e);
                return song;
            }
            
            string line = inFile.ReadLine();

            while(line != null)
            {
                string[] temp = line.Split('#');
                int songID = int.Parse(temp[0]);
                bool delete = bool.Parse(temp[3]);
                if(delete == true)
                {
                    Song.DeleteCountInc();
                }
                DateTime dt3 = DateTime.Parse(temp[2]);

                song.Add(new Song(){ID = songID, Title = temp[1], dateTime = dt3, Delete = delete});

                line = inFile.ReadLine();
                Song.IncCount();
            }
            inFile.Close();

            return song;    
       } 

       public static void AddSong(List<Song> song)
       {
           StreamWriter outFile = new StreamWriter("songs.txt", true);
           foreach(Song a in song)
           {
               outFile.Write(a.ID + "#" + a.Title + "#" + a.dateTime + "#" + a.Delete);
               outFile.WriteLine();
           }
           outFile.Close();
       }
       public static void UpdateSong(List<Song> song)
       {
           StreamWriter outFile = new StreamWriter("songs.txt");
           foreach(Song a in song)
           {
               outFile.Write(a.ID + "#" + a.Title + "#" + a.dateTime + "#" + a.Delete);
               outFile.WriteLine();
           }
           outFile.Close();
       }
    }
}