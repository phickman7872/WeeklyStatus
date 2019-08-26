namespace WeeklyStatus.Core.Models
{
    public class Project : TrackableObject
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
