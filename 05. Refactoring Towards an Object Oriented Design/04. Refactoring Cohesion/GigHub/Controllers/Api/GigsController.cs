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
                .Include(g => g.Attendances.Select(a => a.Attendee))
                .Single(g => g.Id == id && g.ArtistId == userId);

            if (gig.IsCanceled)
                return NotFound();

            gig.Cancel();

            /* All this line is moved to gig.Cancel()
            */
            //gig.IsCanceled = true;
            //var notification = new Notification(NotificationType.GigCanceled, gig);
            //foreach (var attendee in gig.Attendances.Select(a => a.Attendee))
            //    attendee.Notify(notification);

            _context.SaveChanges();

            return Ok();
        }
    }
}
