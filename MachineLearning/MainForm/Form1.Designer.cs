namespace MainForm
{
    partial class Form1
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
            this.pictureView = new System.Windows.Forms.PictureBox();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loadBar, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.buttonLoad, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerator, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelResult, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.161291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.161291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.451613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.903226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.451613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.451613F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1400, 987);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureView
            // 
            this.pictureView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureView.Location = new System.Drawing.Point(73, 53);
            this.pictureView.Name = "pictureView";
            this.tableLayoutPanel1.SetRowSpan(this.pictureView, 7);
            this.pictureView.Size = new System.Drawing.Size(974, 701);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureView.TabIndex = 0;
            this.pictureView.TabStop = false;
            // 
            // loadBar
            // 
            this.loadBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadBar.Location = new System.Drawing.Point(73, 856);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(974, 95);
            this.loadBar.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(1123, 53);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(204, 95);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalc.Location = new System.Drawing.Point(1123, 154);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(204, 95);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Analyze Image";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerator.Location = new System.Drawing.Point(1123, 856);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(204, 95);
            this.buttonGenerator.TabIndex = 4;
            this.buttonGenerator.Text = "Open .arff generator";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Location = new System.Drawing.Point(73, 781);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(974, 48);
            this.labelResult.TabIndex = 5;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1123, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "Based on:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1123, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 101);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(1123, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 101);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(1123, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 152);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 987);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureView;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

