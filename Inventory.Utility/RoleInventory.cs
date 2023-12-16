﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
    public class RoleInventory : IRoleInventory 
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<IdentityUser> _userManager;


        public RoleInventory(RoleManager<IdentityRole> roleManager,
                             UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task AddRoleAsync(string AppUserId)
        {
            var user = await _userManager.FindByIdAsync(AppUserId);
            var roles = _roleManager.Roles;
            List<string> StringRoles =new List<string>();
            if(user != null)
            {
                foreach (var item in roles)
                {
                    StringRoles.Add(item.Name);
                }
                await _userManager.AddToRolesAsync(user, StringRoles);
            }
        }

        public async Task CreateNewRoleAsync()
        {
           Type type = typeof(TopManu);
            foreach(Type classObj in type.GetInterfaces())
            { 
                foreach(var objField in classObj.GetFields())
                {
                    if (objField.Name.Contains("RoleName"))
                    {
                        var roleName = (string)objField.GetValue(objField);
                        if (!await _roleManager.RoleExistsAsync(roleName))
                            await _roleManager.CreateAsync(new IdentityRole(roleName));
                        
                    }
                }
            
                
            }
        }
    }
}
