namespace FinalProjectNew.Models
{
    public class LeaveRequest
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int Id { get; set; }
        public string? RequestComments { get; set; }
        public bool Cancelled { get; set; }
        public Employee RequestingEmployee { get; set; }
        public int EmployeeId { get; set; }
        public DurationType DurationType { get; set; }
    }
}