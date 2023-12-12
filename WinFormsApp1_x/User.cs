using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_x
{
    public class User
    {
       public string username { get; set; }
       public string name { get; set; }
        public int followers_count { get; set; }
        public int following_count { get; set; }

        public string language  { get; set; }
        public string region { get; set; }

        public string[] tweets { get; set; }
        public string[] following { get; set; }
        public string[] followers { get; set; }


    }
}
