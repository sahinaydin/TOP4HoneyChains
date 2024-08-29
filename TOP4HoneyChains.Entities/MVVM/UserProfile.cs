using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP4HoneyChains.Entities.MVVM
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastActitiyDate { get; set; }
    }
}
