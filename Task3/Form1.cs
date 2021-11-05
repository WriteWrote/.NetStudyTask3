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

            // ToDo: make a better way to squeeze the name of the file
            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..." + _disk.getName();

            label7.Text = "Размер диска: " + _disk.getCapacity();
            label8.Text = "Кол-во свободной памяти: " + _disk.getEmptySpace();

            dataGridView1.Rows.Clear();
            foreach (MusicFile file in _disk.getRecordedFiles())
            {
                dataGridView1.Rows.Add(file.ToDataGridRow());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //string filename = _disk.getName() + ".txt"; //saveFileDialog1.FileName;
            String filename = saveFileDialog1.FileName;
            _convertor.WriteToFileFromDisk(_disk, filename);
            MessageBox.Show("Файл сохранен");
        }
    }
}