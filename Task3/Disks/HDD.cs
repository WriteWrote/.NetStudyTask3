using System;
using System.Collections.Generic;

namespace Task3
{
    public class HDD : IDisk
    {
        private readonly Int32 DiskSpace;
        private List<MusicFile> DiskFiles;
        private double TakenDiskSpace;

        public HDD()
        {
            DiskSpace = 256;
            DiskFiles = new List<MusicFile>();
            TakenDiskSpace = 0;
        }

        public HDD(int diskSpace, List<MusicFile> diskFiles)
        {
            DiskSpace = diskSpace;
            DiskFiles = diskFiles;

            TakenDiskSpace = 0;
            foreach (MusicFile musicFile in diskFiles)
            {
                TakenDiskSpace += musicFile.GetSize();
            }
        }
        

        public void RecordFiles(List<MusicFile> files)
        {
            foreach (var musicFile in files)
            {
                if (this.DiskSpace >= this.TakenDiskSpace + musicFile.GetSize())
                {
                    this.TakenDiskSpace += musicFile.GetSize();
                    this.DiskFiles.Add(musicFile);
                }
            }
        }

        public void EraseAll()
        {
            this.DiskFiles = new List<MusicFile>();
            this.TakenDiskSpace = 0;
        }

        List<MusicFile> IDisk.getRecordedFiles()
        {
            return this.DiskFiles;
        }
        
        public int getCapacity()
        {
            return this.DiskSpace;
        }

        double IDisk.getEmptySpace()
        {
            return getEmptySpace();
        }

        public double getEmptySpace()
        {
            return this.DiskSpace - this.TakenDiskSpace;
        }
    }
}