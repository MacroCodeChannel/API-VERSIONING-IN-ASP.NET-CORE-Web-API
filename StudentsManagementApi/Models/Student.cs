using System.ComponentModel.DataAnnotations;

namespace StudentsManagementApi.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
    }
}
