using System;
using Microsoft.AspNetCore.Mvc;

namespace ESBCommunitySite.Models
{
    public class ContactInfo
    {
        //TODO: validation! I want everything filled in
        public string Recipient { get; set; }
        public string MessageText { get; set; }
        public string Sender { get; set; }
    }
}
