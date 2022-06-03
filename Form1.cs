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

        void StartGame ()
        {
            player = 2;
            turns = 0;
            A01.Text = A02.Text = A03.Text = A11.Text = A12.Text = A13.Text = A21.Text = A22.Text = A23.Text = "";
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
                if (CheckDraw()==true)
                {
                    MessageBox.Show("Draw!");
                    sd++;
                    StartGame();
                }

                if (CheckWinner()==true)
                {
                    if(button.Text=="X")
                    {
                        MessageBox.Show("Player 1 Won!");
                        s1++;
                        StartGame();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Won!");
                        s2++;
                        StartGame();
                    }
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

        private void Startbutton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        bool CheckDraw()
        {
            if ((turns==9)&&CheckWinner()==false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //horizontal
            if ((A01.Text == A02.Text) && (A02.Text == A03.Text) && A01.Text != "")
                return true;
            else if ((A11.Text == A12.Text) && (A12.Text == A13.Text) && A11.Text != "")
                return true;
            else if ((A21.Text == A22.Text) && (A22.Text == A23.Text) && A21.Text != "")
                return true;

            //vertical
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;
            else if ((A03.Text == A13.Text) && (A13.Text == A23.Text) && A03.Text != "")
                return true;

            //diagonal
            if ((A01.Text == A12.Text) && (A12.Text == A23.Text) && A01.Text != "")
                return true;
            else if ((A03.Text == A12.Text) && (A12.Text == A21.Text) && A03.Text != "")
                return true;
            else
                return false;
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            StartGame();
        }
    }
}