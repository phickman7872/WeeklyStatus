namespace WeeklyStatus.Core.Models
{
    public class StatusItem : TrackableObject
    {
        public int StatusItemId { get; set; }
        public int StatusTypeId { get; set; }
        public string Description { get; set; }
    }
}
