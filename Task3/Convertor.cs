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
                diskFiles.Add(new MusicFile(p[0], p[1], p[2], p[3],
                    Convert.ToInt32(p[4]), Convert.ToDouble(p[5])));
            }

            return new CD(diskName, sizeOfDisk, diskFiles, takenSpace);
        }

        public void WriteToFileFromDisk(IDisk disk, String filepath)
        {
            File.Create(filepath).Close();
            String file = disk.getCapacity().ToString() + " " +
                          Convert.ToString(disk.getCapacity() - disk.getEmptySpace()) + "\n";
            foreach (MusicFile f in disk.getRecordedFiles())
            {
                file += f.GetName() + " " + f.GetAuthor() + " " + f.GetCollection() + " " + f.GetGenre() +
                        " " + f.GetTime().ToString() + " " + f.GetSize().ToString() + "\n";
            }

            File.WriteAllText(Path.Combine(filepath), file);
        }
    }
}