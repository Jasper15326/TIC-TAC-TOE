using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicTacToe;

namespace Alien_Invaders
{
    public partial class Adminsetup : Form
    {
        private Administrator admin;

        public Adminsetup(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void create_Click(object sender, EventArgs e)
        {
            string playerName = textBox1.Text;
            string playerId = textBox2.Text;
            string playerPassword = textBox3.Text;

            admin.CreatePlayer(playerName, playerId, playerPassword);
            MessageBox.Show("Player created successfully.");
            ClearTextFields();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string playerId = textBox4.Text;
            string newPlayerPassword = textBox5.Text;

            Player playerToUpdate = admin.players.Find(player => player.user_id == playerId);
            if (playerToUpdate != null)
            {
                admin.UpdatePlayerPassword(playerToUpdate, newPlayerPassword);
                MessageBox.Show("Player password updated successfully.");
            }
            else
            {
                MessageBox.Show("Player not found.");
            }
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Optionally, navigate back to the login form or any other initial form
            Firstform firstForm = new Firstform(admin);
            firstForm.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
