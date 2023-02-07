using System.Net.Http.Headers;

namespace NumberGuess
{
    public partial class frmNumberGuess : Form
    {
        List<Label> lblResults = new List<Label>();
        List<PictureBox> picResults = new List<PictureBox>();
        int answer = 0;
        int numGuess = 0;
        int randomMax = 0;
        

        private void StartGame()
        {
            Random random = new Random();
            answer = random.Next(1, randomMax + 1);
            txtGuess.Enabled = true;
            btnStart.Text = "Reset";
        }
        private void ResetGame()
        {
            numGuess = 0;
            btnStart.Enabled = true;
            txtGuess.Enabled = true;
            txtGuess.Text = "";
            btnStart.Text = "Start";

            foreach (Label label in lblResults)
            {
                label.Text = "";
            }

            foreach (PictureBox pic in picResults)
            {
                pic.Image = null;
            }
        }
        private void InitalizeGame()
        {
            lblResults.Add(label4);
            lblResults.Add(label5);
            lblResults.Add(label6);
            lblResults.Add(label7);
            lblResults.Add(label8);

            picResults.Add(pictureBox1);
            picResults.Add(pictureBox2);
            picResults.Add(pictureBox3);
            picResults.Add(pictureBox4);
            picResults.Add(pictureBox5);
            
        }
        public frmNumberGuess()
        {
            InitializeComponent();
        }

        private void frmNumberGuess_Load(object sender, EventArgs e)
        {
            InitalizeGame();
            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Text == "Start")
            {
                StartGame();
            }
            else //Reset
            {
                ResetGame();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked ==true)
            {
                randomMax = 10; //easy to guess, not too high
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                randomMax = 20; //Medium
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                randomMax = 30; //Medium
            
            
            }
        }

        private void GameWon()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("You won! You are the best!!!");
            //Application.Exit(); //exits app 
        }

        private void GameLost()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("You sucK!!!! the awnser was: " + answer + ", so close !!!!!");

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}