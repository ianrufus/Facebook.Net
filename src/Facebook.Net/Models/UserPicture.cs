using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class UserPicture
    {
        public int Height;
        public bool Redirect;
        public string Type; // enum
        public ProfilePictureSource Data;
        public Paging Paging;
    }
}
