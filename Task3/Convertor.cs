using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Task3
{
    public class Convertor
    {
        public IDisk ReadFromFileToCdDisk(String filename)
        {
            string fileText = System.IO.File.ReadAllText(filename);
            //string diskName = filename.Substring(filename.Length - 10, 6);
            string diskName = filename;
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

        public void WriteToFileFromDisk(IDisk temp, IDisk disk) //, bool proceed)
        {
            if (disk.getEmptySpace() >= temp.getReservedSpace())
            {
                List<MusicFile> l = disk.getRecordedFiles();
                l.AddRange(temp.getRecordedFiles());
                disk.EraseAll();
                disk.RecordFiles(l);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Размер записываемых файлов больше, чем размер свободного места на диске.\nЗаписать сколько получится?",
                    "Настройки записи файлов",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    double sizeOfFiles = disk.getReservedSpace();
                    double emptySpace = disk.getEmptySpace();
                    int i = 0;
                    List<MusicFile> l = disk.getRecordedFiles();
                    while (i < temp.getRecordedFiles().Count &&
                           disk.getCapacity() >= sizeOfFiles)
                    {
                        l.Add(temp.getRecordedFiles()[i]);
                        sizeOfFiles += temp.getRecordedFiles()[i].GetSize();
                        i++;
                    }

                    disk.EraseAll();
                    disk.RecordFiles(l);
                }
            }

            // writing files down to .txt
            String text = disk.getCapacity() + " " + (disk.getReservedSpace()) + "\r\n";
            foreach (MusicFile file in disk.getRecordedFiles())
            {
                text += file.ToString();
            }

            System.IO.File.WriteAllText(disk.getFullName(), text);
        }
    }
}