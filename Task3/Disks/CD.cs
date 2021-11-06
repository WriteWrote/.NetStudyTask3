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

        public CD(String name)
        {
            _name = name;
            _diskSpace = 15;
            _diskFiles = new List<MusicFile>();
            _takenDiskSpace = 0;
        }

        public CD(String name, List<MusicFile> files)
        {
            this._name = name;
            _diskSpace = 15;
            _diskFiles = files;
            foreach (var file in files)
            {
                _takenDiskSpace += file.GetSize();
            }
        }

        public CD(String name, int diskSpace, List<MusicFile> diskFiles)
        {
            this._name = name;
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

        public CD(String name, int diskSpace, List<MusicFile> diskFiles, double reservedPlace)
        {
            this._name = name;
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
            //ToDo: remove hardcode
            return _name.Substring(_name.Length - 10, 5);
        }

        public String getFullName()
        {
            return _name;
        }

        public double getReservedSpace()
        {
            return _takenDiskSpace;
        }
    }
}