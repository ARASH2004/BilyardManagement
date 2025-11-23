using Domain.Shared;
using Domain.Tables;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reservations
{
    public class Reservation:BaseEntity
    {
        public Guid TableId { get;private set; }
        public Guid TournomentId { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime StartAt { get; private set; }
        public DateTime EndAt { get; private set; }
        public bool IsTournoment { get; private set; } =false;
        public double PricePerHour { get; private set; }
        public User User { get; private set; }
        public Tornument Tornument { get; private set; }
        public Table Table { get; private set; }

        public Reservation(Guid TabelId ,Guid UserId, DateTime StartAt,DateTime EndAt,double PricePerHour)
        {
            Gurd(StartAt, EndAt);
            this.TableId = TabelId;
            this.UserId = UserId;
            this.StartAt = StartAt;
            this.EndAt = EndAt;
            this.PricePerHour = PricePerHour;
        }
        private static void Gurd(DateTime StartAt, DateTime EndAt)
        {
            if (StartAt > EndAt)
            {
                throw new ArgumentOutOfRangeException("Start Date Must be Less than End");
            }
        }
        public void Setturnoment(Guid turnomentId)
        {
            this.TournomentId = turnomentId;
            this.IsTournoment = true;
        }
    }
}
