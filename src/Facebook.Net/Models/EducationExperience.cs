using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class EducationExperience
    {
        public string ID;
        public List<Experience> Classes;
        public List<Page> Concentration;
        public Page Degree;
        public Page School;
        public string Type;
        public List<User> With;
        public Page Year;
    }
}
