using System;

namespace Task3
{
    public class MusicFile
    {
        private String Name;
        private String Author;
        private String Collection;
        private String Genre;

        // time in seconds
        private int time;

        // size in gb
        private double size;

        public MusicFile(String name, String author, String collection, String genre, int time, double size)
        {
            this.Name = name;
            this.Author = author;
            this.Collection = collection;
            this.Genre = genre;
            this.time = time;
            this.size = size;
        }

        public String GetName()
        {
            return this.Name;
        }
        public String GetAuthor()
        {
            return this.Author;
        }
        public String GetCollection()
        {
            return this.Collection;
        }
        public String GetGenre()
        {
            return this.Genre;
        }
        public int GetTime()
        {
            return this.time;
        }
        public double GetSize()
        {
            return this.size;
        }

        public string[] ToDataGridRow()
        {
            return new string[] {Name, Author, Collection, Genre, time.ToString(), size.ToString()};
        }

        public override string ToString()
        {
            return Name + " " + Author + " " + Collection + " " + Genre + " "
                   + time.ToString() + " " + size.ToString() + "\r\n";
        }
    }
}