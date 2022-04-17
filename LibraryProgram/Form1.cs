namespace LibraryProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "kku")
            {
                MessageBox.Show("กรุณาใส่ Usename ไม่ถูกต้อง");
            }
            if (textBox2.Text != "kku64")
            {
                MessageBox.Show("กรุณาใส่ Password ไม่ถูกต้อง");
            }
            if (textBox1.Text == "kku" && textBox2.Text == "kku64")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
                
            }
        }

        private void buttonStaftRegis_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}