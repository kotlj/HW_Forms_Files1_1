namespace HW_Forms_Files1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            progressBar1 = new ProgressBar();
            buttonOpen = new Button();
            labelProcces = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(12, 118);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(776, 320);
            textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 83);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 29);
            progressBar1.TabIndex = 1;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 65);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Open FIle";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // labelProcces
            // 
            labelProcces.AutoSize = true;
            labelProcces.Location = new Point(362, 60);
            labelProcces.Name = "labelProcces";
            labelProcces.Size = new Size(0, 20);
            labelProcces.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelProcces);
            Controls.Add(buttonOpen);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private ProgressBar progressBar1;
        private Button buttonOpen;
        private Label labelProcces;
        private System.Windows.Forms.Timer timer1;
    }
}