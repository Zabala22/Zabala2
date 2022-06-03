namespace Tictactoe
{
    public partial class Tictactoe : Form
    {
        public Tictactoe()
        {
            InitializeComponent();
        }

        public int player=2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerX.Text = "X: " + s1;
            PlayerO.Text = "O: " + s2;
            Draw.Text = "Draws: " + sd;
        }

        private void TictactoeClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerO_Click(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}