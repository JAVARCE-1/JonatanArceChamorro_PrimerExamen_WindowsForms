namespace Tic_Tac_Toc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtPlayer0 = new TextBox();
            txtPlayerX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnExit = new Button();
            btnReset = new Button();
            btnNuevo = new Button();
            panel4 = new Panel();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 28);
            label2.Name = "label2";
            label2.Size = new Size(839, 60);
            label2.TabIndex = 1;
            label2.Text = "JUEGO TIC TAC TOC - WINDOWS FORM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 41);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtPlayer0);
            panel2.Controls.Add(txtPlayerX);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(427, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 125);
            panel2.TabIndex = 1;
            // 
            // txtPlayer0
            // 
            txtPlayer0.Font = new Font("Segoe UI", 16.2F);
            txtPlayer0.Location = new Point(220, 64);
            txtPlayer0.Name = "txtPlayer0";
            txtPlayer0.Size = new Size(56, 43);
            txtPlayer0.TabIndex = 3;
            // 
            // txtPlayerX
            // 
            txtPlayerX.Font = new Font("Segoe UI", 16.2F);
            txtPlayerX.Location = new Point(220, 15);
            txtPlayerX.Name = "txtPlayerX";
            txtPlayerX.Size = new Size(56, 43);
            txtPlayerX.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(24, 64);
            label4.Name = "label4";
            label4.Size = new Size(149, 38);
            label4.TabIndex = 1;
            label4.Text = "PLAYER 0:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(24, 15);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 0;
            label3.Text = "PLAYER X:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(btnNuevo);
            panel3.Location = new Point(427, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 191);
            panel3.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnExit.Location = new Point(221, 97);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(204, 82);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnReset.Location = new Point(3, 97);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(204, 82);
            btnReset.TabIndex = 1;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnNuevo.Location = new Point(3, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(422, 82);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "NEW GAME";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnNueve);
            panel4.Controls.Add(btnOcho);
            panel4.Controls.Add(btnSiete);
            panel4.Controls.Add(btnSeis);
            panel4.Controls.Add(btnCinco);
            panel4.Controls.Add(btnCuatro);
            panel4.Controls.Add(btnTres);
            panel4.Controls.Add(btnDos);
            panel4.Controls.Add(btnUno);
            panel4.Location = new Point(8, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(413, 322);
            panel4.TabIndex = 2;
            // 
            // btnNueve
            // 
            btnNueve.Location = new Point(275, 213);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(131, 99);
            btnNueve.TabIndex = 8;
            btnNueve.Text = "button9";
            btnNueve.UseVisualStyleBackColor = true;
            // 
            // btnOcho
            // 
            btnOcho.Location = new Point(140, 213);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(131, 99);
            btnOcho.TabIndex = 7;
            btnOcho.Text = "button8";
            btnOcho.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            btnSiete.Location = new Point(5, 212);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(131, 99);
            btnSiete.TabIndex = 6;
            btnSiete.Text = "button7";
            btnSiete.UseVisualStyleBackColor = true;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(275, 108);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(131, 99);
            btnSeis.TabIndex = 5;
            btnSeis.Text = "button6";
            btnSeis.UseVisualStyleBackColor = true;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(140, 108);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(131, 99);
            btnCinco.TabIndex = 4;
            btnCinco.Text = "button5";
            btnCinco.UseVisualStyleBackColor = true;
            // 
            // btnCuatro
            // 
            btnCuatro.Location = new Point(5, 108);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(131, 99);
            btnCuatro.TabIndex = 3;
            btnCuatro.Text = "button4";
            btnCuatro.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(275, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(131, 99);
            btnTres.TabIndex = 2;
            btnTres.Text = "button3";
            btnTres.UseVisualStyleBackColor = true;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(140, 4);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(131, 99);
            btnDos.TabIndex = 1;
            btnDos.Text = "button2";
            btnDos.UseVisualStyleBackColor = true;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(5, 4);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(131, 99);
            btnUno.TabIndex = 0;
            btnUno.Text = "button1";
            btnUno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 484);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnExit;
        private Button btnReset;
        private Button btnNuevo;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private TextBox txtPlayer0;
        private TextBox txtPlayerX;
    }
}
