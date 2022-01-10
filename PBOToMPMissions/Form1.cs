using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOToMPMissions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string lokacija;
        public string path = @"%localappdata%\Arma 3\MPMissionsCache\";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Odaberite PBO",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pbo",
                Filter = "PBO Fajlovi (*.pbo)|*.pbo",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            lokacija = openFileDialog1.FileName;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            path = Environment.ExpandEnvironmentVariables(path);
            File.Copy(lokacija, path + Path.GetFileName(lokacija), true);
            Thread.Sleep(1000);
            string message = "Kopiranje je završeno, možete izaći iz programa!";
            string title = "Arma Klan Munje";
            MessageBox.Show(message, title);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
