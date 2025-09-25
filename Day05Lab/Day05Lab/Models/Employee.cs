namespace Day05Lab.Models
{
    public enum employeeStatus
    {
        Active,
        Inactive,
    }
    public class Employee
    {
        public string id;
        public string name;
        public int gender;
        public string phone;
        public string email;
        public float salary;
        public employeeStatus status;
    }
}
