namespace WeeklyStatus.Core.Models
{
    public class Permission : TrackableObject
    {
        public int PermissionId { get; set; }
        public int ParentPermissionId { get; set; }
        public int PermissionTypeId { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }
    }
}
