using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class WorkExperience
    {
        public string ID;
        public string Description;
        public Page Employer;
        [JsonProperty("end_date")]
        public string EndDate;
        public User From;
        public Page Location;
        public Page Position;
        public List<ProjectExperience> Projects;
        [JsonProperty("start_date")]
        public string StartDate;
        public List<User> With;
    }
}
