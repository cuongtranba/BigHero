using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigHero.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
 

}