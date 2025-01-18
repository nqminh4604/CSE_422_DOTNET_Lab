using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class PremiumMember : Member
    {
        public PremiumMember(string memberID, string name, string email, DateTime membershipExpiry, int maxBooksAllowed) : base(memberID, name, email)
        {
            MembershipExpiry = membershipExpiry;
            MaxBooksAllowed = maxBooksAllowed;
        }

        public DateTime MembershipExpiry { get; set; }

        public int MaxBooksAllowed { get; set; }

        public override string DisplayInfo()
        {
            string info = base.DisplayInfo()
                + "Membership Expiry: " + MembershipExpiry + "\n"
                + "Max book allowed: " + MaxBooksAllowed + "\n";
            return info;
        }
    }
}
