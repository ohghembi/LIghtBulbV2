namespace LampadinaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        int y = 89, x = 368;
        private void button3_Click(object sender, EventArgs e)
        {
            if (y>-10)
            {
                pictureBox1.Location = new Point(x, y - 10);
                pictureBox2.Location = new Point(x, y - 10);

                y = y - 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(x, y + 10);
            pictureBox2.Location = new Point(x, y - 10);

            y = y + 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
