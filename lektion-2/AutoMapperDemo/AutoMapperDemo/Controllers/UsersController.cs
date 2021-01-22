﻿using AutoMapper;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Controllers
{
    public class UsersController : Controller
    {
        private IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            var user = GetUserDetails();
            var userViewModel = _mapper.Map<UserViewModel>(user);
                        
            return View(userViewModel);
        }




        private static User GetUserDetails()
        {
            return new User
            {
                Id = 1,
                FirstName = "Samuel",
                LastNamme = "Wessen",
                Email = "samuelwessen@hotmail.com",
                Password = "bytmig123"
            };
        }
    }
}
