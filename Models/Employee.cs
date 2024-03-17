using Microsoft.AspNetCore.Identity;

namespace FinalProjectNew.Models
{
    public class Employee
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int YearsServed { get; set; }
        public int Id { get; set; }
    }
}
