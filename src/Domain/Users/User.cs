using Domain.Reservations;
using Domain.Shared;
using Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class User:BaseEntity
    {
        public string UserName { get;private set; }
        public string UserPassword { get; private set; }
        public string? UserProfilePic {  get;private set; }
        public int Age { get; private set; }
        public UserLevel Level { get; private set; }
        public List<Reservation> Reservations { get; private set; }
        public List<Tornument> WinnedTornument { get; private set; }
        public User(string UserName, string UserPassword, int Age, string? UserProfilePic = null)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserProfilePic = UserProfilePic;
            this.Age = Age;
            this.Level = UserLevel.Begginer;
        }

        public void UpdateUserLevel(UserLevel Level)
        {
            this.Level=Level;
            this.UpdatedAt=DateTime.Now;
        }

    }
}
