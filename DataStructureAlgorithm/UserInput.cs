using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class UserInput
    {
        public void ReplaceString()
        {
            string input = "Hello <<name>>,We have your full name as <<fullname>> your Mobile Number is xxxxxxxxxx.";
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            input = input.Replace("<<name>>", name);

            Console.WriteLine("Enter fullName");
            string fullname = Console.ReadLine();
            input = input.Replace("<<fullname>>", fullname);

            Console.WriteLine("Enter MobileNumber");
            string mobile = Console.ReadLine();
            input = input.Replace("xxxxxxxxxx", mobile);

            Console.WriteLine(input);


        }
    }
}
