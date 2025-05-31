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

        }

        private void btnDos_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }
    }
}
