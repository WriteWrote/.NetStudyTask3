using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    public class Convertor
    {
        public IDisk ReadFromFileToCdDisk(String filename)
        {
            string fileText = System.IO.File.ReadAllText(filename);
            string diskName = filename.Substring(filename.Length - 10, 6);
            Int32 sizeOfDisk = Convert.ToInt32(fileText.Split('\n')[0].Trim().Split(' ')[0]);
            Double takenSpace = Convert.ToDouble(fileText.Split('\n')[0].Trim().Split(' ')[1]);

            List<MusicFile> diskFiles = new List<MusicFile>();
            foreach (String line in fileText.Split('\n'))
            {
                // ToDo: сделать более элегантный способ пропустить первую строку
                if (line.Split(' ').Length == 2 || line.Length == 0)
                    continue;

                String[] p = line.Trim().Split(' ');
                for (int i = 0; i < 4; i++)
                {
                    if ("".Equals(p[i])) p[i] = "NoName";
                }
                diskFiles.Add(new MusicFile(p[0], p[1], p[2], p[3],
                    Convert.ToInt32(p[4]), Convert.ToDouble(p[5])));
            }

            return new CD(diskName, sizeOfDisk, diskFiles, takenSpace);
        }

        public void WriteToFileFromDisk(IDisk disk, String filename)
        {
            
            String text = disk.getCapacity() + " " + (disk.getCapacity() - disk.getEmptySpace()) + "\r\n";

            foreach (MusicFile file in disk.getRecordedFiles())
            {
                text += file.ToString();
            }
            
            System.IO.File.WriteAllText(filename, text);
        }
    }
}