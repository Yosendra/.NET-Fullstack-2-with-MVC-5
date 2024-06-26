﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }

        [Required]
        public int GigId { get; private set; }
        public Gig Gig { get; private set; }

        protected Notification()
        {
        }

        public Notification(NotificationType type, Gig gig)
        {
            Gig = gig ?? throw new ArgumentNullException("Gig is null.");
            Type = type;
            DateTime = DateTime.Now;
        }
    }
}