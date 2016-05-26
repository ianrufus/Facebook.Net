using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Experience
    {
        public string ID;
        public string Description;
        public User From;
        public string Name;
        public List<User> With;
    }
}
