using System.Collections.Generic;

namespace TicTacToe
{
    public abstract class User
    {
        public string user_id { get; set; }
        protected internal  string user_password { get; set; }

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool VerifyLogin(string id, string pass)
        {
            return id.Equals(this.user_id) && pass.Equals(this.user_password);
        }

        public abstract void UpdatePassword(string newPassword);
    }

    public class Administrator : User
    {
        public string admin_name { get; set; }
        public List<Player> players { get; private set; }

        public Administrator(string adminName, string adminId, string password) : base(adminId, password)
        {
            this.admin_name = adminName;
            players = new List<Player>();
        }

        public void CreatePlayer(string playerName, string playerId, string playerPassword)
        {
            Player newPlayer = new Player(playerName, playerId, playerPassword);
            players.Add(newPlayer);
        }

        public void UpdatePlayerPassword(Player player, string newPassword)
        {
            player.UpdatePassword(newPassword);
        }

        public override void UpdatePassword(string newPassword)
        {
            user_password = newPassword;
        }
    }

    public class Player : User
    {
        public string Name { get; set; }

        public Player(string name, string userId, string password) : base(userId, password)
        {
            Name = name;
        }

        public override void UpdatePassword(string newPassword)
        {
            user_password = newPassword;
        }
    }
}
