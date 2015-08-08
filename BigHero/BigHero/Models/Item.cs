using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigHero.Models
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
    }
}