using Npgsql.PostgresTypes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public Guid Id { get; private set; }
        public string Fullname { get; private set; }
        public int Age { get; private set; }
        public string Postalcode { get; private set; }

        public Employee(string fullname, int age, string postalcode)
        {
            Id = Guid.NewGuid();
            Fullname = fullname ?? throw new ArgumentNullException(nameof(fullname));
            Age = age;
            Postalcode = postalcode;
        }
    }
}
