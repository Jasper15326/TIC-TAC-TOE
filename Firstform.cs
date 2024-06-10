using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe;

namespace Alien_Invaders
{
    public partial class Firstform : Form
    {
        private Administrator admin;

        public Firstform(Administrator adminName)
        {
            InitializeComponent();
            admin = adminName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin(admin);
            adminLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerLogincs playerLogin = new PlayerLogincs(admin);
            playerLogin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Firstform_Load(object sender, EventArgs e)
        {

        }
    }
}
