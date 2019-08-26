using System;

namespace WeeklyStatus.Core.Models
{
    public class TrackableObject
    {
        public string UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public string UserDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string UserUpdated { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
