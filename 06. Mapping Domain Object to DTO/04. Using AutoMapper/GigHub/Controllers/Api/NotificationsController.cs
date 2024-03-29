using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public NotificationsController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<NotificationDto> GetNotifications()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _context.UserNotifications
                .Where(un => un.UserId == userId)
                .Select(un => un.Notification)
                .Include(n => n.Gig.Artist)
                .ToList();

            // Create the mapping profile
            Mapper.CreateMap<Notification, NotificationDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<ApplicationUser, UserDto>();

            // With AutoMapper, mapping become simple
            return notifications.Select(Mapper.Map<Notification, NotificationDto>);

            // Manual mapping to dto object
            //return notifications.Select(n => new NotificationDto
            //{
            //    DateTime = n.DateTime,
            //    Gig = new GigDto
            //    {
            //        Id = n.Gig.Id,
            //        Artist = new UserDto
            //        {
            //            Id = n.Gig.Artist.Id,
            //            Name = n.Gig.Artist.Name,
            //        },
            //        DateTime = n.Gig.DateTime,
            //        Venue = n.Gig.Venue,
            //        IsCanceled = n.Gig.IsCanceled,
            //    },
            //    OriginalDateTime = n.OriginalDateTime,
            //    OriginalVenue = n.OriginalVenue,
            //    Type = n.Type,
            //});
        }
    }
}
