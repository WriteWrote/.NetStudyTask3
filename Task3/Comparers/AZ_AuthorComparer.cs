using System.Collections.Generic;

namespace Task3.Comparers
{
    public class AZ_AuthorComparer : IComparer<MusicFile>
    {
        public int Compare(MusicFile x, MusicFile y)
        {
            if (x == null || y == null)
                return 0;
            else if (x.GetAuthor()[0] > y.GetAuthor()[0])
            {
                return 1;
            }
            else if (x.GetAuthor()[0] < y.GetAuthor()[0])
            {
                return -1;
            }
            else
                return 0;
        }
    }
}