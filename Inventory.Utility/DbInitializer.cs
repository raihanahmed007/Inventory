using Inventory.Models;
using Inventory.Utility.HelperClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
    public class DbInitializer:IDbInitializer
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private SuperAdmin _superAdmin;

        public DbInitializer(UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager, IOptions<SuperAdmin> superAdmin)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _superAdmin = superAdmin.Value;
        }

        public async void CreateSuperAdmin()
        {
            AppUser user = new AppUser();
            user.Email = "";
            user.UserName = "";
            user.EmailConfirmed = true;
            var response = await _userManager.CreateAsync(user, _superAdmin.Password);
        }

        public Task SendEmail(string FromEmail, string FromName, string Massage, string toEmail, string toName, string smtpUser, string smtpPassword, string smtpHost, string smtpPort, bool smtpSSL)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string Directory)
        {
            throw new NotImplementedException();
        }
    }
}
