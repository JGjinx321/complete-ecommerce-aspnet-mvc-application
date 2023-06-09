﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    //Definition of fields and relationships for Producer class.
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
