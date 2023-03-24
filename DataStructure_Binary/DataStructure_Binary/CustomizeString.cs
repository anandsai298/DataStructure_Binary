using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class CustomizeString
    {
        public void Customize()
        {
            string Line = "Hello <<name>> we have your fullname <<fullname>> in our system with your phone number <<phno>>";
            Line = Line.Replace("<<name>>", "ASk");
            Line = Line.Replace("<<fullname>>", "AnandSaiKumar");
            Line = Line.Replace("<<phno>>", "9299999769");
            Console.WriteLine(Line);
        }
    }
}
