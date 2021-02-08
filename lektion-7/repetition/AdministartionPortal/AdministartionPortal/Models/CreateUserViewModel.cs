using AdministartionPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdministartionPortal.Models
{
    public class CreateUserViewModel : ApplicationUser
    {
        public string Password { get; set; }
    }
}
