﻿using System;
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
            var gig = _context.Gigs.Single(g => g.Id == id && g.ArtistId == userId);

            if (gig.IsCanceled)
                return NotFound();

            gig.IsCanceled = true;

            var notification = new Notification
            {
                DateTime = DateTime.Now,
                GigId = gig.Id,
                Type = NotificationType.GigCanceled,
            };

            var attendees = _context.Attendances
                .Where(a => a.GigId == gig.Id)
                .Select(a => a.Attendee)
                .ToList();

            foreach (var attendee in attendees)
            {
                attendee.Notify(notification);

                //var userNotification = new UserNotification
                //{
                //    User = attendee,
                //    Notification = notification,
                //};
                //_context.UserNotifications.Add(userNotification);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
