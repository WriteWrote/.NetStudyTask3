using System;
using System.Collections.Generic;

namespace Task3
{
    public class HDD : IDisk
    {
        private String _name;
        private readonly Int32 _diskSpace;
        private List<MusicFile> _diskFiles;
        private double _takenDiskSpace;

        public HDD()
        {
            _diskSpace = 256;
            _diskFiles = new List<MusicFile>();
            _takenDiskSpace = 0;
        }

        public HDD(int diskSpace, List<MusicFile> diskFiles)
        {
            _diskSpace = diskSpace;
            _diskFiles = diskFiles;

            _takenDiskSpace = 0;
            foreach (MusicFile musicFile in diskFiles)
            {
                _takenDiskSpace += musicFile.GetSize();
            }
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
        }

        public void EraseAll()
        {
            this._diskFiles = new List<MusicFile>();
            this._takenDiskSpace = 0;
        }

        List<MusicFile> IDisk.getRecordedFiles()
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

        public String getName()
        {
            return this._name;
        }

        public void setName(String name)
        {
            this._name = name;
        }
    }
}