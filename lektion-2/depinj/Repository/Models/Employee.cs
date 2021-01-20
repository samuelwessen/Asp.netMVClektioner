using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Repository.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
