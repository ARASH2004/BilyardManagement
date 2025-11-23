using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public class BaseEntity
    {
        public Guid Id { get;protected set; }
        public DateTime CreatedAt { get;protected set; }= DateTime.Now;
        public DateTime UpdatedAt { get;protected set; }
        public DateTime DeletedAt { get; protected set; }
        public bool IsDeleted { get; protected set; }=false;
        
        public void Remove()
        {
            IsDeleted = true;
            DeletedAt = DateTime.Now;
        }

    }
}
