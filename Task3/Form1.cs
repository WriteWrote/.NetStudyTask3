using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private IDisk _disk;
        private Convertor _convertor;

        public Form1()
        {
            InitializeComponent();

            _disk = new CD("UnknownDisk");
            _convertor = new Convertor();
            
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button_filepick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog1.FileName;
            _disk = _convertor.ReadFromFileToCdDisk(filename);
            
/*            string fileText = System.IO.File.ReadAllText(filename);
            
            string diskName = filename.Substring(filename.Length - 10, 6);
            Int32 sizeOfDisk = Convert.ToInt32(fileText.Split('\n')[0].Trim().Split(' ')[0]);
            Double takenSpace = Convert.ToDouble(fileText.Split('\n')[0].Trim().Split(' ')[1]);
*/            
            // ToDo: make a better way to squeeze the name of the file
            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..." + _disk.getName();
            
            label7.Text = "Размер диска: " + _disk.getCapacity();
            label8.Text = "Кол-во свободной памяти: " + _disk.getEmptySpace();
/*            
            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..." + diskName;
            
            label7.Text = "Размер диска: " + sizeOfDisk.ToString();
            label8.Text = "Кол-во свободной памяти: " + (sizeOfDisk - takenSpace).ToString();
*/
/*            List<MusicFile> diskFiles = new List<MusicFile>();
            foreach (String line in fileText.Split('\n'))
            {
                // ToDo: сделать более элегантный способ пропустить первую строку
                if (line.Split(' ').Length ==2 || line.Length==0)
                    continue;

                String[] p = line.Trim().Split(' ');
                diskFiles.Add(new MusicFile(p[0], p[1], p[2],p[3],
                    Convert.ToInt32(p[4]), Convert.ToDouble(p[5])));
            }
            this._disk = new CD(diskName, sizeOfDisk, diskFiles, takenSpace);
*/            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //string filename = _disk.getName() + ".txt"; //saveFileDialog1.FileName;
            String filename = saveFileDialog1.FileName;
            _convertor.WriteToFileFromDisk(_disk, filename);
/*            
            String text = _disk.getCapacity() + " " + (_disk.getCapacity() - _disk.getEmptySpace()) + "\r\n";

            foreach (MusicFile file in _disk.getRecordedFiles())
            {
                text += file.ToString();
            }
            
            System.IO.File.WriteAllText(filename, text);
*/            
            MessageBox.Show("Файл сохранен");
        }
    }
}