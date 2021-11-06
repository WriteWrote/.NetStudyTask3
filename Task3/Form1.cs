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
using Task3.Comparers;

namespace Task3
{
    public partial class Form1 : Form
    {
        private IDisk _disk;
        private IDisk _temp;
        private IDisk _computer;
        private Convertor _convertor;

        public Form1()
        {
            InitializeComponent();

            _disk = new CD("emptyCD");
            _temp = new CD("temporarySorting");
            _computer = new HDD("HDD");
            _convertor = new Convertor();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "D:\\XXX\\WorkingFiles\\C#_2021\\Task3\\Task3\\Recources\\DiskC.txt";
            _computer = _convertor.ReadFromFileToCdDisk(filename);
            _temp = _convertor.ReadFromFileToCdDisk(filename);
            display(_computer);
        }

        private void displayTempParams()
        {
            label12.Text = "Количество: " + _temp.getRecordedFiles().Count().ToString();
            int time = 0;
            double size = 0;
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                time += file.GetTime();
                size += file.GetSize();
            }

            label13.Text = "Длительность: " + time.ToString();
            label14.Text = "Размер: " + size.ToString();
        }

        private void display(IDisk disk)
        {
            dataGridView1.Rows.Clear();
            foreach (MusicFile file in disk.getRecordedFiles())
            {
                dataGridView1.Rows.Add(file.ToDataGridRow());
            }

            displayTempParams();
        }

        private void button_filepick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            _disk = _convertor.ReadFromFileToCdDisk(filename);

            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..." + _disk.getName();
            label7.Text = "Размер диска: " + _disk.getCapacity();
            label8.Text = "Кол-во свободной памяти: " + _disk.getEmptySpace();

            //display(_disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _convertor.WriteToFileFromDisk(_temp, _disk);
            MessageBox.Show("Файл сохранен");
            display(_disk);
        }

        private void button_ConfirmSorting_Click(object sender, EventArgs e)
        {
            //ToDo: адаптировать к сортировке компьютерного ХДД и съемного диска
            _disk = new CD(_disk.getName(), _disk.getCapacity(), _temp.getRecordedFiles());
            _temp = new CD("temporarySorting");
            display(_disk);
        }

        private void button_backToHDD_Click(object sender, EventArgs e)
        {
            //ToDO: make possible to redact and see the content of new disks along the computer HDD
        }

        private void button_AZ_name_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            //if (_disk == null)
            sortList = _computer.getRecordedFiles();
            //else
            //sortList = _disk.getRecordedFiles();
            sortList.Sort(new AZ_NameComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_ZA_name_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new ZA_NameComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_downsize_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new DecreasingSizeComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_upsize_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new IncreasingSizeComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_downtime_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new DecreasingTimeComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_uptime_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new IncreasingTimeComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_AZ_author_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new AZ_AuthorComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_ZA_author_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new ZA_AuthorComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_AZ_genre_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new AZ_GenreComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_ZA_genre_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new ZA_GenreComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_AZ_collection_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new AZ_CollectionComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_ZA_collection_Click(object sender, EventArgs e)
        {
            List<MusicFile> sortList;
            sortList = _computer.getRecordedFiles();
            sortList.Sort(new ZA_CollectionComparer());
            _temp = new CD(_temp.getFullName(), sortList);
            display(_temp);
        }

        private void button_findName_Click(object sender, EventArgs e)
        {
            string substring = textBox_name.Text.ToLower();
            _temp.getRecordedFiles().Clear();

            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _computer.getRecordedFiles())
            {
                if(file.GetName().ToLower().Contains(substring))
                    pickedFiles.Add(file);
            }
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }
    }
}