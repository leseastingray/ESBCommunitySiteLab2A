using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESBCommunitySite.Models
{
    public class Member
    {
        public string Name { get; set; }
        // should this just be a method?
        public string Instrument { get; set; }
        public string DateJoined { get; set; }
        public bool Board { get; set; }
        public bool SectionLeader { get; set; }

        // method to add additional instrument (for members who play 
        //  more than one instrument)
        public static void AddInstrument(string instrument)
        {
            Member.AddInstrument(instrument);
        }
    }
}
