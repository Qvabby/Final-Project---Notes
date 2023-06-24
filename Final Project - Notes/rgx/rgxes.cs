using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Final_Project___Notes.rgx
{
    public class rgxes
    {
        public static Regex EmailRegex = new Regex(@"^[a-zA-Z0-9]{5,20}@[a-z]{1,15}.[a-z]{1,15}$");
    }
}
