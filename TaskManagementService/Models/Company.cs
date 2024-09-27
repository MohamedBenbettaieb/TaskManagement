using System.Collections.Generic;

namespace TaskManagementService.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}