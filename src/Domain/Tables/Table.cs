using Domain.Reservations;
using Domain.Shared;
using Domain.Shared.Enums;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tables
{
    public class Table:BaseEntity
    {
        public long TableNumber { get;private set; } 
        public bool IsActive { get; private set; } = true;
        public TableType Type { get;private set; }
        public List<Reservation > reservations { get; private set; }
        public double PricePerHour { get; private set; }


        public Table(long TableNumber, bool IsActive, TableType Type, double PricePerHour)
        {
            this.TableNumber = TableNumber;
            this.IsActive = IsActive;
            this.Type = Type;
            this.PricePerHour = PricePerHour;
        }
        public void UpdatePrice(double PricePerHour)
        {
            this.PricePerHour = PricePerHour;
            this.UpdatedAt = DateTime.Now;
        }
        public void SetNotActive()
        {
            this.IsActive = false;
            this.UpdatedAt = DateTime.Now;
        }
    }
}
