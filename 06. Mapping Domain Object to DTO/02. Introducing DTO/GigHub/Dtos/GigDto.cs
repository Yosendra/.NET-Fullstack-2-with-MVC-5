using GigHub.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace GigHub.Dtos
{
    public class GigDto
    {
        public int Id { get; set; }

        //public ApplicationUser Artist { get; set; }
        public UserDto Artist { get; set; }

        //[Required]
        //public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        //[Required]
        //[StringLength(255)]
        public string Venue { get; set; }

        //[Required]
        //public byte GenreId { get; set; }
        //public Genre Genre { get; set; }
        public GenreDto Genre { get; set; }

        public bool IsCanceled { get; private set; }

        //public ICollection<Attendance> Attendances { get; private set; }
    }
}