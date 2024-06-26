﻿using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class GigsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var gig = _context.Gigs
                .Include(g => g.Attendances.Select(a => a.Attendee))  // add navigation property "Attendances" in Gigs class, notice the lamda in include() and select()
                .Single(g => g.Id == id && g.ArtistId == userId);

            if (gig.IsCanceled)
                return NotFound();

            gig.IsCanceled = true;
            var notification = new Notification(NotificationType.GigCanceled, gig);

            //var attendees = _context.Attendances
            //    .Where(a => a.GigId == gig.Id)
            //    .Select(a => a.Attendee)
            //    .ToList();

            var attendees = gig.Attendances.Select(a => a.Attendee);
            foreach (var attendee in attendees)
                attendee.Notify(notification);

            _context.SaveChanges();

            return Ok();
        }
    }
}
