using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faceBook
{
    class users
    {
        //Fields
        string Fname;
        string LastName; 
        string email;
        long mobileNo;
        DateTime dob;

      
        //Properties
        public string Fname1 { get => Fname; set => Fname = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Email { get => email; set => email = value; }
        public long MobileNo { get => mobileNo; set => mobileNo = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        //Constructor
        public users()
        {
        }

        public users(string fname, string lastName, string email, long mobileNo, DateTime dob)
        {
            Fname = fname;
            LastName = lastName;
            this.email = email;
            this.mobileNo = mobileNo;
            this.dob = dob;
        }

        //override String
        public override string ToString()
        {
            return String.Format("Fname is : {0}   lname is : {1}   email is : {2}  MobileNumber is: {3}  dob is: {4} ", Fname1,LastName1,Email,MobileNo,Dob);

        }

        public override bool Equals(object obj)
        {
            users u = (users)obj;
            return this.email.Equals(u.email) && this.mobileNo.Equals(u.mobileNo);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
