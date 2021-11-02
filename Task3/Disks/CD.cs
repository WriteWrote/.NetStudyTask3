using System;
using System.Collections.Generic;

namespace Task3
{
    public class CD : IDisk
    {
        private readonly Int32 DiskSpace;
        private List<MusicFile> DiskFiles;
        private double TakenDiskSpace;

        public CD()
        {
            DiskSpace = 15;
            DiskFiles = new List<MusicFile>();
            TakenDiskSpace = 0;
        }

        public CD(int diskSpace, List<MusicFile> diskFiles)
        {
            DiskSpace = diskSpace;
            DiskFiles = diskFiles;

            TakenDiskSpace = 0;
            foreach (MusicFile musicFile in diskFiles)
            {
                TakenDiskSpace += musicFile.GetSize();
            }
            //String[] l = diskFiles.Split('\n');
            //TakenDiskSpace = Convert.ToInt32(l[0].Split(' ')[2]);
        }
        public CD(int diskSpace, List<MusicFile> diskFiles, double reservedPlace)
        {
            DiskSpace = diskSpace;
            DiskFiles = diskFiles;
            TakenDiskSpace = reservedPlace;
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
            /*String[] l = files.Split('\n');
            String[] Params = l[0].Split(' ');
            int sizeOfFiles = Convert.ToInt32(Params[2]);

            if (this.TakenDiskSpace + sizeOfFiles <= this.DiskSpace)
            {
                files.Substring(0, Params[0].Length + Params[1].Length + 3);
                this.DiskFiles += files;
            }*/
        }

        public void EraseAll()
        {
            this.DiskFiles = new List<MusicFile>();
            this.TakenDiskSpace = 0;
        }

        public List<MusicFile> getRecordedFiles()
        {
            return this.DiskFiles;
        }

        public int getCapacity()
        {
            return this.DiskSpace;
        }

        public double getEmptySpace()
        {
            return this.DiskSpace - this.TakenDiskSpace;
        }
    }
}