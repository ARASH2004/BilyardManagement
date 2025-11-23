using Domain.Shared;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reservations
{
    public class Tornument:BaseEntity
    {
        public Guid ResId { get;private set; }
        public Reservation Reservation { get; private set; }
        public List<UserTornUment> Participants { get; private set; } = new List<UserTornUment>();
        public Guid WinnerUserId { get; private set; }
        public User User { get; private set; }
        public Tornument(Guid ResId)
        {
           this.ResId = ResId;
        }
        public void AddParticipant(List<UserTornUment> Participants)
        {
            this.Participants.AddRange(Participants);
            this.UpdatedAt = DateTime.Now;
        }
        public void SetWinnerUser(Guid UserId)
        {
            this.WinnerUserId = UserId;
        }
    }
}
