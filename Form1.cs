namespace HW_Forms_Files1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(fileName);
            progressBar1.Value = 0;
            timer1.Start();
            labelProcces.Text = "Reading...";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                textBox1.Text = fileText;
                labelProcces.Text = "done!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
        }
    }
}