using System;
using System.Collections.Generic;

namespace Task3
{
    public class CD : IDisk
    {
        private readonly Int32 DiskSpace;
        private List<MusicFile> DiskFiles;
        private Int32 TakenDiskSpace;

        public CD()
        {
            DiskSpace = 15;
            DiskFiles = "";
            TakenDiskSpace = 0;
        }

        public CD(int diskSpace, String diskFiles)
        {
            DiskSpace = diskSpace;
            DiskFiles = diskFiles;

            String[] l = diskFiles.Split('\n');
            TakenDiskSpace = Convert.ToInt32(l[0].Split(' ')[2]);
        }

        public void RecordFiles(string files)
        {
            String[] l = files.Split('\n');
            String[] Params = l[0].Split(' ');
            int sizeOfFiles = Convert.ToInt32(Params[2]);

            if (this.TakenDiskSpace + sizeOfFiles <= this.DiskSpace)
            {
                files.Substring(0, Params[0].Length + Params[1].Length + 3);
                this.DiskFiles += files;
            }
        }

        public void EraseAll()
        {
            this.DiskFiles = this.DiskSpace.ToString() + " 0\n";
            this.TakenDiskSpace = 0;
        }

        public string getRecordedFiles()
        {
            return this.DiskFiles;
        }

        public int getCapacity()
        {
            return this.DiskSpace;
        }

        public int getEmptySpace()
        {
            return this.DiskSpace - this.TakenDiskSpace;
        }
    }
}