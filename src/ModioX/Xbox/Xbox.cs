using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDevkit
{
    partial class Xbox
    {
        static Xbox()
        {
            Console.WriteLine(string.Format("Hey {0} is using me!", Environment.UserName));
        }
    }
}
