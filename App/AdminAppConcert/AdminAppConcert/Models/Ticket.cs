using System.ComponentModel.DataAnnotations;
using System;

namespace AdminAppConcert.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid SportEventId { get; set; }
        public SportsEvents? SportsEvents { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}
