namespace Tic_Tac_Toc
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne = 0;


        public void Enable_False()
        {
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
        }

        public void Score()
        {
            #region Player X
            if (btnUno.Text =="X" && btnDos.Text =="X" && btnTres.Text =="X")
            {
                btnUno.BackColor = Color.Green;
                btnDos.BackColor = Color.Green;
                btnTres.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne =Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnUno.Text == "X" && btnCuatro.Text == "X" && btnSiete.Text == "X")
            {
                btnUno.BackColor = Color.Green;
                btnCuatro.BackColor = Color.Green;
                btnSiete.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnUno.Text == "X" && btnCinco.Text == "X" && btnNueve.Text == "X")
            {
                btnUno.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnDos.Text == "X" && btnCinco.Text == "X" && btnOcho.Text == "X")
            {
                btnDos.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnOcho.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTres.Text == "X" && btnSeis.Text == "X" && btnNueve.Text == "X")
            {
                btnTres.BackColor = Color.Green;
                btnSeis.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnCuatro.Text == "X" && btnCinco.Text == "X" && btnSeis.Text == "X")
            {
                btnCuatro.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnSeis.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnSiete.Text == "X" && btnOcho.Text == "X" && btnNueve.Text == "X")
            {
                btnSiete.BackColor = Color.Green;
                btnOcho.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTres.Text == "X" && btnCinco.Text == "X" && btnSiete.Text == "X")
            {
                btnTres.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnSiete.BackColor = Color.Green;

                MessageBox.Show("Player X Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            #endregion

            #region Player O

            if (btnUno.Text == "0" && btnDos.Text == "0" && btnTres.Text == "0")
            {
                btnUno.BackColor = Color.Green;
                btnDos.BackColor = Color.Green;
                btnTres.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnUno.Text == "0" && btnCuatro.Text == "0" && btnSiete.Text == "0")
            {
                btnUno.BackColor = Color.Green;
                btnCuatro.BackColor = Color.Green;
                btnSiete.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnUno.Text == "0" && btnCinco.Text == "0" && btnNueve.Text == "0")
            {
                btnUno.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnDos.Text == "0" && btnCinco.Text == "0" && btnOcho.Text == "0")
            {
                btnDos.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnOcho.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTres.Text == "0" && btnSeis.Text == "0" && btnNueve.Text == "0")
            {
                btnTres.BackColor = Color.Green;
                btnSeis.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnCuatro.Text == "0" && btnCinco.Text == "0" && btnSeis.Text == "0")
            {
                btnCuatro.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnSeis.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnSiete.Text == "0" && btnOcho.Text == "0" && btnNueve.Text == "0")
            {
                btnSiete.BackColor = Color.Green;
                btnOcho.BackColor = Color.Green;
                btnNueve.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btnTres.Text == "0" && btnCinco.Text == "0" && btnSiete.Text == "0")
            {
                btnTres.BackColor = Color.Green;
                btnCinco.BackColor = Color.Green;
                btnSiete.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins!", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            #endregion
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnUno.Text = "X";
                checker = true;
            }
            else
            {
                btnUno.Text = "0";
                checker = false;
            }
            Score();
            btnUno.Enabled = false;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnDos.Text = "X";
                checker = true;
            }
            else
            {
                btnDos.Text = "0";
                checker = false;
            }
            Score();
            btnDos.Enabled = false;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTres.Text = "X";
                checker = true;
            }
            else
            {
                btnTres.Text = "0";
                checker = false;
            }
            Score();
            btnTres.Enabled = false;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnCuatro.Text = "X";
                checker = true;
            }
            else
            {
                btnCuatro.Text = "0";
                checker = false;
            }
            Score();
            btnCuatro.Enabled = false;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnCinco.Text = "X";
                checker = true;
            }
            else
            {
                btnCinco.Text = "0";
                checker = false;
            }
            Score();
            btnCinco.Enabled = false;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnSeis.Text = "X";
                checker = true;
            }
            else
            {
                btnSeis.Text = "0";
                checker = false;
            }
            Score();
            btnSeis.Enabled = false;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnSiete.Text = "X";
                checker = true;
            }
            else
            {
                btnSiete.Text = "0";
                checker = false;
            }
            Score();
            btnSiete.Enabled = false;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnOcho.Text = "X";
                checker = true;
            }
            else
            {
                btnOcho.Text = "0";
                checker = false;
            }
            Score();
            btnOcho.Enabled = false;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnNueve.Text = "X";
                checker = true;
            }
            else
            {
                btnNueve.Text = "0";
                checker = false;
            }
            Score();
            btnNueve.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnUno.Enabled = true;
            btnDos.Enabled = true;
            btnTres.Enabled = true;
            btnCuatro.Enabled = true;
            btnCinco.Enabled = true;
            btnSeis.Enabled = true;
            btnSiete.Enabled = true;
            btnOcho.Enabled = true;
            btnNueve.Enabled = true;

            btnUno.Text = "";
            btnDos.Text = "";
            btnTres.Text = "";
            btnCuatro.Text = "";
            btnCinco.Text = "";
            btnSeis.Text = "";
            btnSiete.Text = "";
            btnOcho.Text = "";
            btnNueve.Text = "";

            lblPlayerO.Text = "0";
            lblPlayerX.Text = "0";

            btnUno.BackColor = Color.White;
            btnDos.BackColor = Color.White;
            btnTres.BackColor = Color.White;
            btnCuatro.BackColor = Color.White;
            btnCinco.BackColor = Color.White;
            btnSeis.BackColor = Color.White;
            btnSiete.BackColor = Color.White;
            btnOcho.BackColor = Color.White;
            btnNueve.BackColor = Color.White;

        }
    }
}
