using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTripProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        // collection: interface
        public ICollection<Comment> Commetns { get; set; }
    }
}
