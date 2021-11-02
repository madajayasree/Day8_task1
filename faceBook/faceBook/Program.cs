using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faceBook
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            users[] obj_users;
            Console.WriteLine("Enter number of users");
            int obj_count;
            obj_count = int.Parse(Console.ReadLine());
            obj_users = new users[obj_count];
            for (int i = 0; i < obj_count; i++)
            {
                string user_Fname;
                string user_LastName;
                string user_email;
                long user_mobileNo;
                DateTime user_dob;
                
                Console.WriteLine("Enter Fname: ");
                user_Fname = Console.ReadLine();

                Console.WriteLine("Enter Lastname: ");
                user_LastName = Console.ReadLine();

                Console.WriteLine("Enter Email: ");
                user_email = Console.ReadLine();

                Console.WriteLine("Enter MobileNumber: ");
                user_mobileNo = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter Date of Birth: ");
                user_dob = Convert.ToDateTime(Console.ReadLine());

                users obj = new users(user_Fname, user_LastName, user_email, user_mobileNo, user_dob);



                if (!obj_users.Contains(obj))
                {
                    obj_users[i] = obj;
                }
                else
                {
                    Console.WriteLine("accouont is already exits re_enter the account details: ");
                    i--;
                }
            }

            foreach(var item in obj_users)
            {
                Console.WriteLine(item);
            }
             

        }
    }
}
