using System;
using System.Collections.Generic;

namespace Task3
{
    public class CD : IDisk
    {
        private String _name;
        private readonly Int32 _diskSpace;
        private List<MusicFile> _diskFiles;
        private double _takenDiskSpace;

        public CD()
        {
            _diskSpace = 15;
            _diskFiles = new List<MusicFile>();
            _takenDiskSpace = 0;
        }

        public CD(int diskSpace, List<MusicFile> diskFiles)
        {
            _diskSpace = diskSpace;
            _diskFiles = diskFiles;

            _takenDiskSpace = 0;
            foreach (MusicFile musicFile in diskFiles)
            {
                _takenDiskSpace += musicFile.GetSize();
            }
            //String[] l = diskFiles.Split('\n');
            //TakenDiskSpace = Convert.ToInt32(l[0].Split(' ')[2]);
        }
        public CD(int diskSpace, List<MusicFile> diskFiles, double reservedPlace)
        {
            _diskSpace = diskSpace;
            _diskFiles = diskFiles;
            _takenDiskSpace = reservedPlace;
        }

        public void RecordFiles(List<MusicFile> files)
        {
            foreach (var musicFile in files)
            {
                if (this._diskSpace >= this._takenDiskSpace + musicFile.GetSize())
                {
                    this._takenDiskSpace += musicFile.GetSize();
                    this._diskFiles.Add(musicFile);
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
            this._diskFiles = new List<MusicFile>();
            this._takenDiskSpace = 0;
        }

        public List<MusicFile> getRecordedFiles()
        {
            return this._diskFiles;
        }

        public int getCapacity()
        {
            return this._diskSpace;
        }

        public double getEmptySpace()
        {
            return this._diskSpace - this._takenDiskSpace;
        }

        public void setName(String name)
        {
            this._name = name;
        }

        public String getName()
        {
            return this._name;
        }
    }
}