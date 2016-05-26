using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Options
{
    public class UserPhotosOptions
    {
        public bool allow_spherical_photo { get; set; }
        // How to handle non boolean parameters?
        // Guesding we check the type, special casing how they're handled
        // e.g. bools are just appended, strings are appended with =value or something
    }
}
