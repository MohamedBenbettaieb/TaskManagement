namespace TaskManagementService.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public Status Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? ParentTaskId { get; set; }

    }
}
