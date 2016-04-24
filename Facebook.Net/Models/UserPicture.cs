using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class UserPicture
    {
        public int height;
        public bool redirect;
        public string type; // enum
        public ProfilePictureSource data;
        public Paging paging;
    }
}
