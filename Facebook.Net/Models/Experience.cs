using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Experience
    {
        public string id;
        public string description;
        public User from;
        public string name;
        public List<User> with;
    }
}
