using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe;

namespace Alien_Invaders
{
    public partial class PlayerLogincs : Form
    {
        private Administrator admin;

        public PlayerLogincs(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerId = textBox1.Text;
            string playerPassword = textBox2.Text;

            Player player = admin.players.Find(p => p.user_id == playerId);

            if (player != null && player.VerifyLogin(playerId, playerPassword))
            {
                MessageBox.Show("Login successful!");
                Form1 form = new Form1(admin);
                form.Show();
                // Proceed to the next step, such as opening the game window
            }
            else
            {
                MessageBox.Show("Invalid player ID or password.");
            }

            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
