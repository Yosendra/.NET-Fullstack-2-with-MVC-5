using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; private set; }             // meke this private setter, because we have use Factory method
        public string OriginalVenue { get; private set; }                   // meke this private setter, because we have use Factory method

        [Required]
        public int GigId { get; private set; }
        public Gig Gig { get; private set; }

        protected Notification()
        {
        }

        // change this into private
        private Notification(NotificationType type, Gig gig)
        {
            Gig = gig ?? throw new ArgumentNullException("Gig is null.");
            Type = type;
            DateTime = DateTime.Now;
        }

        // Factory method for notification object for Gig created
        public static Notification GigCreated(Gig gig)                      
        {
            return new Notification(NotificationType.GigCreated, gig);
        }

        // Factory method for notification object for Gig created
        public static Notification GigUpdated(Gig newGig, DateTime originalDateTime, string originalVenue)
        {
            return new Notification(NotificationType.GigUpdated, newGig)
            {
                OriginalDateTime = originalDateTime,
                OriginalVenue = originalVenue,
            };
        }

        // Factory method for notification object for Gig created
        public static Notification GigCanceled(Gig gig)
        {
            return new Notification(NotificationType.GigCanceled, gig);
        }
    }
}