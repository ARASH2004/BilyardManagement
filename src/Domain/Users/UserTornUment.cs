using Domain.Reservations;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class UserTornUment:BaseEntity
    {
        public Guid UserId { get;private set; }
        public Guid TornUmentId { get; private set; }
        public User User { get; private set; }
        public Tornument Tornument { get; private set; }


        public UserTornUment(Guid userId, Guid tornUmentId)
        {
            UserId = userId;
            TornUmentId = tornUmentId;
        }
    }
}
