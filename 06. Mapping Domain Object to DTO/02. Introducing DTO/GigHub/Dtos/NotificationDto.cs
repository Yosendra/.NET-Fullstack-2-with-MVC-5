using GigHub.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace GigHub.Dtos
{
    public class NotificationDto
    {
        //public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; private set; }
        public string OriginalVenue { get; private set; }
        //public int GigId { get; private set; }
        //public Gig Gig { get; private set; }      // return the Dto not domain class
        public GigDto Gig { get; private set; }
    }
}