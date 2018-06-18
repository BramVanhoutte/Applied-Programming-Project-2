namespace TrainingGenerator
{
    partial class TrainingGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.buttonSelectPictures = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectPictures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerate.Location = new System.Drawing.Point(372, 463);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(364, 76);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Load .arff file";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(363, 75);
            this.button.TabIndex = 0;
            this.button.Text = "open Clipart folder";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSelectPictures
            // 
            this.buttonSelectPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectPictures.Location = new System.Drawing.Point(3, 84);
            this.buttonSelectPictures.Name = "buttonSelectPictures";
            this.buttonSelectPictures.Size = new System.Drawing.Size(363, 75);
            this.buttonSelectPictures.TabIndex = 1;
            this.buttonSelectPictures.Text = "open Picture folder";
            this.buttonSelectPictures.UseVisualStyleBackColor = true;
            this.buttonSelectPictures.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(372, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 81);
            this.label1.TabIndex = 4;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\bramvanhoutte\\Desktop";
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.SelectedPath = "C:\\Users\\bramvanhoutte\\Desktop";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = ".arff file destination";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TrainingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrainingGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TrainingGUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonSelectPictures;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

