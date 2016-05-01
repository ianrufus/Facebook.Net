using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Privacy
    {
        public string Allow;
        public string Deny;
        public string Description;
        public string Friends; // Enum
        public string Networks;
        public string Value; // Enum
    }
}
