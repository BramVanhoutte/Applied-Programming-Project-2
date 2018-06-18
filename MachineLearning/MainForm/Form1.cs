using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingGenerator;

namespace MainForm
{
    public partial class Form1 : Form
    {
        WekaTree tree = new WekaTree();
        Features feat;
        public Form1(Features feat)
        {
            InitializeComponent();
            this.feat = feat;
            feat.PartProcessed += PartProcessedEventHandler;
            ClearResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void PartProcessedEventHandler(int percentage)
        {
            loadBar.Value = percentage;
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureView.Load(openFileDialog1.FileName);
                ClearResult();
            }
           
        }

        private void buttonGenerator_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new TrainingGUI();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (pictureView.Image != null)
            {
                feat.Img = new Bitmap(pictureView.Image);
                feat.Analyze();
                LogicLayer.Type k = tree.stepOne(feat);
                SetResult(k);
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void SetResult(LogicLayer.Type k)
        {
            if (k == LogicLayer.Type.Clipart)
            {
                labelResult.Text = "The image is clipart.";
            }
            else
            {
                labelResult.Text = "The image is a picture.";
            }
            label1.Text = "Based on:";
            label2.Text = (Math.Round(100 * feat.DifferentColors)) / 100.0 + "% of the pixels having different colors.";
            label3.Text = (Math.Round(100 * feat.MaxPercentage)) / 100.0 + "% of the pixels are the most occuring color.";
            if (feat.Transparency) label4.Text = "There being transparent pixel(s) in the image.";
            else label4.Text = "There not being transparent pixel(s) in the image.";
        }

        private void ClearResult()
        {
            labelResult.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
}
