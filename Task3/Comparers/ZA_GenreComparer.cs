using System.Collections.Generic;

namespace Task3.Comparers
{
    public class ZA_GenreComparer : IComparer<MusicFile>
    {
        public int Compare(MusicFile x, MusicFile y)
        {
            if (x == null || y == null)
                return 0;
            else if (x.GetGenre()[0] > y.GetGenre()[0])
            {
                return -1;
            }
            else if (x.GetGenre()[0] < y.GetGenre()[0])
            {
                return 1;
            }
            else
                return 0;
        }
    }
}