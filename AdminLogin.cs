using System;
using System.Windows.Forms;
using TicTacToe;

namespace Alien_Invaders
{
    public partial class AdminLogin : Form
    {
        private Administrator admin;

        // Modified constructor to accept an Administrator instance
        public AdminLogin(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;   // Assuming you have a TextBox named textBox1
            string password = textBox2.Text;  // Assuming you have a TextBox named textBox2

            if (admin.VerifyLogin(userId, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Adminsetup setup = new Adminsetup(admin); // Pass the admin instance to Adminsetup
                setup.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
