namespace WeeklyStatus.Core.Models
{
    public class StatusType : TrackableObject
    {
        public int StatusTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
