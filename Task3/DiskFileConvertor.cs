using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    public class DiskFileConvertor
    {
        public IDisk ReadFromFileToCDDisk(String filepath)
        {
            String textFromFile = File.ReadAllText(filepath);
            //File.ReadAllText("D:\\XXX\\WorkingFiles\\C#_2021\\Task2\\Task2\\resources\\text2.txt");
            String[] lines = textFromFile.Split('\n');

            // DiskParams[0] == Disk Capacity
            // DiskParams[1] == ReservedCapacity 
            String[] diskParams = lines[0].Split(' ');

            List<MusicFile> musicFiles = new List<MusicFile>();

            for (int i = 1; i < lines.Length; i++)
            {
                String[] lV = lines[i].Split(' ');
                musicFiles.Add(new MusicFile(lV[0], lV[2], lV[3], lV[4],
                    Convert.ToInt32(lV[5]), Convert.ToInt32(lV[6])));
            }

            IDisk newDisk = new CD(Convert.ToInt32(diskParams[0]), musicFiles,
                Convert.ToInt32(diskParams[1]));
            return newDisk;
        }

        public void WriteToFileFromDisk(IDisk disk, String filepath)
        {
        }
    }
}