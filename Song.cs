using System;
using System.Collections.Generic;

namespace PA1_321
{
    public class Song :IComparable<Song>
    {
        public int ID {get; set;}
        public string Title {get; set;}
        public DateTime dateTime {get; set;}
        public bool Delete {get; set;}
        public static int count = 1;
        public static int deleteCount;
        public static void IncCount()
        {
            count++;
        }
        public static void DeleteCountInc()
        {
            deleteCount++;
        }
        public int CompareTo(Song temp)
        {
            return this.dateTime.CompareTo(temp.dateTime);
        }        

    }
}