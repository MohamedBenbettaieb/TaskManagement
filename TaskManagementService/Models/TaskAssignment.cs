namespace TaskManagementService.Models
{
    public class TaskAssignment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
