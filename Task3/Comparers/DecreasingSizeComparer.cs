using System.Collections.Generic;

namespace Task3.Comparers
{
    public class DecreasingSizeComparer : IComparer<MusicFile>
    {
        public int Compare(MusicFile x, MusicFile y)
        {
            if (x == null || y == null)
                return 0;
            else if (x.GetSize() > y.GetSize())
            {
                return 1;
            }
            else if (x.GetSize() < y.GetSize())
            {
                return -1;
            }
            else
                return 0;
        }
    }
}