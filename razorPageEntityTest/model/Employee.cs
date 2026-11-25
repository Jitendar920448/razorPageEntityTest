using System.ComponentModel.DataAnnotations;

namespace razorPageEntityTest.model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }
    }
}
