using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class EmployeeViewModel
    {
        public Guid Id { get; private set; }
        [Display(Name = "fullname")]
        public string Fullname { get; private set; }
        [Display(Name = "age")]
        public int Age { get; private set; }
        [Display(Name = "postalcode")]
        public string Postalcode { get; private set; }

        public EmployeeViewModel(string fullname, int age, string postalcode)
        {
            Id = Guid.NewGuid();
            Fullname = fullname;
            Age = age;
            Postalcode = postalcode;
        }
    }
}
