using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public class Roster
    {
        // list for collection of members
        public static List<Member> members = new List<Member>();

        // enable enumeration
        public static IEnumerable<Member> Members
        {
            get
            {
                return members;
            }
        }

        // method to add members to roster
        public static void AddMember(Member member)
        {
            members.Add(member);
        }
    }
}
