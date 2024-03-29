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

            // We put this mapping profile logic to MappingProfile class
            //Mapper.CreateMap<Notification, NotificationDto>();
            //Mapper.CreateMap<Gig, GigDto>();
            //Mapper.CreateMap<ApplicationUser, UserDto>();

            return notifications.Select(Mapper.Map<Notification, NotificationDto>);
        }
    }
}
