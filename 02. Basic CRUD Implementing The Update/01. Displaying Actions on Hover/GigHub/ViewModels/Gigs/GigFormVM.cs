using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GigHub.Models;
using GigHub.ViewModels.CustomDataAnnotations;

namespace GigHub.ViewModels.Gigs
{
    public class GigFormVM
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        public DateTime GetDateTime() => DateTime.Parse(string.Format("{0} {1}", Date, Time));

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}