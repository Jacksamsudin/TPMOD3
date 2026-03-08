using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP_MODUL3_103022400074
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;  // menyimpan angka sebelumnya
        private bool inputBaru = true;   // flag untuk input angka baru

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "1"; inputBaru = false; }
            else label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "2"; inputBaru = false; }
            else label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "3"; inputBaru = false; }
            else label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "4"; inputBaru = false; }
            else label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "5"; inputBaru = false; }
            else label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "6"; inputBaru = false; }
            else label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "7"; inputBaru = false; }
            else label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "8"; inputBaru = false; }
            else label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputBaru) { label1.Text = "9"; inputBaru = false; }
            else label1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e) // tombol 0
        {
            if (inputBaru) { label1.Text = "0"; inputBaru = false; }
            else if (label1.Text != "0") label1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e) // tombol +
        {
            if (double.TryParse(label1.Text, out double current))
                accumulator += current;

            inputBaru = true;
        }

        private void button12_Click(object sender, EventArgs e) // tombol =
        {
            if (double.TryParse(label1.Text, out double current))
            {
                accumulator += current;

                label1.Text = (accumulator == Math.Truncate(accumulator))
                    ? ((long)accumulator).ToString()
                    : accumulator.ToString();
            }

            accumulator = 0;
            inputBaru = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}