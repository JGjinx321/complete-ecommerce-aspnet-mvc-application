using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    //Definition of fields and relationships in Cinema class
    public class Cinema
    {
        [Key]
        public int Id{ get; set; }

        public string Logo { get; set; }

        public string name { get; set; }

        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
