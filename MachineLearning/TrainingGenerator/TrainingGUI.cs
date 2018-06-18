using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingGenerator
{
    public partial class TrainingGUI : Form
    {
        string[] filesClipart;
        string[] filesPictures;

        string savePath;

        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        public TrainingGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filesClipart = Directory.GetFiles(folderBrowserDialog1.SelectedPath); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                filesPictures = Directory.GetFiles(folderBrowserDialog2.SelectedPath);
            }
        }

      


        private void StartFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fs = File.Create(path))
                {
                }
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("% 1.Title: Machine Learning Images");
                    sw.WriteLine("%");
                    sw.WriteLine("% 2.Sources: ");
                    sw.WriteLine("% 	(a) Creator: Bram Vanhoutte");
                    sw.WriteLine("% 	(b) Date: November, 2017");
                    sw.WriteLine("%");
                    sw.WriteLine("");
                    sw.WriteLine("@RELATION Image");
                    sw.WriteLine("");
                    sw.WriteLine("@attribute amountColors numeric");
                    sw.WriteLine("@attribute transparency {True, False}");
                    sw.WriteLine("@attribute maxPercentage numeric");
                    sw.WriteLine("@attribute type {Clipart, Picture}");
                    sw.WriteLine("");
                    sw.WriteLine("@DATA");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void GenerateData(string path)
        {
            List<Features> data = new List<Features>();
            double prog = 0.0;
            var stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(filesClipart, img =>
            {
                if (ImageExtensions.Contains(Path.GetExtension(img).ToUpperInvariant()))
                {
                    Features temp = new Features(new Bitmap(img), LogicLayer.Type.Clipart);
                    lock(data) {
                        data.Add(temp);
                    }
                }
                prog += (1.0 / (filesClipart.Length + filesPictures.Length)) * 100.0;
                   
            });

            Parallel.ForEach(filesPictures, img =>
            {
                if (ImageExtensions.Contains(Path.GetExtension(img).ToUpperInvariant()))
                {
                    Features temp = new Features(new Bitmap(img), LogicLayer.Type.Picture);
                    lock (data)
                    {
                        data.Add(temp);
                    }
                }
                

            });
            label1.Text = stopWatch.Elapsed.TotalSeconds + "";

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach(Features item in data) {
                    sw.WriteLine(item.DifferentColors + "," + item.Transparency.ToString() + "," + item.MaxPercentage + "," + item.T);
                }
            }

        }

        private void TrainingGUI_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {  
            StartFile(savePath);
            GenerateData(savePath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog1.FileName;
            }
        }
    }
}
