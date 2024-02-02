using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MusicLibrary.Users
{
    public class UserManager
    {

        public List<User> RegisteredUsers { get; set; } = new List<User>();
        public User CurrentUser { get; set; }

        public void AddUser(string username, string password)
        {
            if (RegisteredUsers.Any(u => u.Name.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Username already exists.");
            }

            User newUser = new User(username, password);

            newUser.CreatePlaylist("My Playlist");

            RegisteredUsers.Add(newUser);
        }

        public void SaveUsersToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(RegisteredUsers);
            File.WriteAllText(filePath, json);
        }

        public void LoadUsersFromJson(string filePath) 
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                RegisteredUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
