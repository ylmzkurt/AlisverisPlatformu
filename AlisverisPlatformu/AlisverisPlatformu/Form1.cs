namespace AlisverisPlatformu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Giyim")
            {
                listBox1.Items.Add(textBox1.Text);
            }

            else if (textBox2.Text == "Elektronik")
            {
                listBox2.Items.Add(textBox1.Text);
            }

            if (textBox2.Text == "Aksesuar")
            {
                listBox3.Items.Add(textBox1.Text);
            }

            if (textBox2.Text == "Kýrtasiye")
            {
                listBox4.Items.Add(textBox1.Text);
            }

            if (textBox2.Text == "Süpermarket")
            {
                listBox5.Items.Add(textBox1.Text);
            }
        }
    }
}
