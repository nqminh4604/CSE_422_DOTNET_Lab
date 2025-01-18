using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Member
    {
        private string _memberId;
        private string _name;
        private string _email;

        public Member(string memberID, string name, string email)
        {
            this._memberId = memberID;
            this._name = name;
            this._email = email;
        }

        public string MemberId { 
            get { return _memberId; }
            set { _memberId = value; }
        }
        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public string Email { 
            get { return _email; }
            set {_email = value; }
        }

        public virtual string DisplayInfo()
        {
            string info =
                 "Member ID: " + MemberId + "\n"
                 + "Name" + Name + "\n"
                 + "Email" + Email + "\n";
            return info;
        }
    }
}
