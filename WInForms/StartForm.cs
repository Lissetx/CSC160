namespace WInForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "The form has loaded";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "The button has been clicked";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}