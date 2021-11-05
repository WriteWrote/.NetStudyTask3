using System.Collections.Generic;

namespace Task3.Comparers
{
    public class ZA_NameComparer : IComparer<MusicFile>
    {
        public int Compare(MusicFile x, MusicFile y)
        {
            if (x == null || y == null)
                return 0;
            else if (x.GetName()[0] > y.GetName()[0])
            {
                return -1;
            }
            else if (x.GetName()[0] < y.GetName()[0])
            {
                return 1;
            }
            else
                return 0;
        }
    }
}