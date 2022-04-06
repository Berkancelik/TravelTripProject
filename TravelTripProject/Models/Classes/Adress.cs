using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTripProject.Models.Classes
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string AdresDescription { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string Map { get; set; }
    }
}
