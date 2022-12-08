namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int S = int.Parse(textBox1.Text);
            int N = (int)numericUpDown1.Value;
            if (comboBox1.SelectedIndex == 0)
            {
                N *= 12;
            }
            double P = int.Parse(textBox3.Text) / 12;

            double res = P * Math.Pow(1 + P)
            label4.Text=;
        }
    }
}