using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCompany.Models
{
    public class User : BaseDomain<int>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastActivation { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}
