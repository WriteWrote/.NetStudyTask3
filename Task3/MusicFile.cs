using System;

namespace Task3
{
    public class MusicFile
    {
        private String Name;
        private String Author;
        private String Collection;

        private Genres Genre;

        // time in seconds
        private int time;

        // size in gb
        private double size;

        public MusicFile(String name, String author, String collection, Genres genre, int time, double size)
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
        public Genres GetGenre()
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
        

        public override string ToString()
        {
            return Name + " " + Author + " " + Collection + " " + Genre.ToString() + " "
                   + time.ToString() + " " + size.ToString() + "\n";
        }
    }
}