﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNamme { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}
