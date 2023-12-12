using Newtonsoft.Json;
using System.IO;

namespace WinFormsApp1_x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string json = File.ReadAllText("C:\\Users\\bjk_m\\OneDrive\\Masaüstü\\twitter_data.json");

            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            label1.Text = users[0].username;

            Dictionary<string, User> userTable = new Dictionary<string, User>();
            foreach (User user in users)
            {
                userTable.Add(user.username, user);
            }

            label1.Text = userTable["burcu06"].username;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
