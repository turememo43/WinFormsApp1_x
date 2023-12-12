using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_x
{
    public class UserTableSingleton // Kullanıcıların her biri için bir nesne oluşturulmalı ve bu kullanıcı nesneleri Hash tabloları ile organize edilmelidir isterini yerine getirir
    {

        private static UserTableSingleton _instance;
        public static UserTableSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserTableSingleton();
                }
                return _instance;
            }
        }

        public Dictionary<string, User> UserTable { get; private set; }

        private UserTableSingleton()
        {
            UserTable = new Dictionary<string, User>();
        }

        public void LoadData()
        {
            string json = File.ReadAllText("C:\\Users\\bjk_m\\OneDrive\\Masaüstü\\twitter_data.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

            // Kullanıcıları UserTable'a ekleyin.
            foreach (User user in users)
            {
                UserTable.Add(user.username, user);
            }
        }

    }
}
