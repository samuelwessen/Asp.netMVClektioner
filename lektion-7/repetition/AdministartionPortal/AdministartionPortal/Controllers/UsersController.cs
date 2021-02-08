﻿using AdministartionPortal.Data;
using AdministartionPortal.Models;
using AdministartionPortal.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdministartionPortal.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly IIdentityService _identityService;

        public UsersController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Users =  await _identityService.GetAllUsersWithRolesAsync();
            ViewBag.Roles = _identityService.GetAllRoles();

            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {

            //SKULLE BEHÖVA ANVÄNDA AUTOMAPPER HÄR ANNARS MÅSTE JAG MAPPA UPP ALLT FRÅN APLICATIONUSER (HAR INTE GJORT DET HÄR NERE)
            var user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                // username och email har samma värde så går att ha email på UserName = model.Email
                UserName = model.Email
            };

            await _identityService.CreateNewUserAsync(user, model.Password);

            return RedirectToAction("Index");
        }
    }
}
