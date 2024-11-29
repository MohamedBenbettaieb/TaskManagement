using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TaskManagementService.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid CompanyId { get; set; }
        private string Password { get; set; }
        private bool IsConfirmed {  get; set; }
        public Status Status {  get; set; } 
        public Role Role { get; set; }

    }
}