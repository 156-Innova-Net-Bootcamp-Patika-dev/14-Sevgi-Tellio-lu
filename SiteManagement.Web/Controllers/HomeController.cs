using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteManagament.Core;
using SiteManagement.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiteManagement.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private AppDbContext Db;
        public HomeController(ILogger<HomeController> logger, AppDbContext applicationContext)
        {
            _logger = logger;
            Db = applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Email,string Password)
        {
            Tenant tenant = Db.Tenants.FirstOrDefault(x => x.Email == Email);
            if (tenant == null)
            {
                return View();
            }
            var result = tenant.Password == Password;
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            if (result)
            {
                var tenantRoles = Db.Tenants.Where(ur =>ur.Role.Id == tenant.RoleId);
                var roles = Db.Roles.Where(ro => tenantRoles.Any(ur => ur.Role.Id == ro.Id));
                identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                foreach (var item in roles)
                {
                   identity.AddClaim(new Claim(ClaimTypes.Role, item.RoleName));
                }
                identity.AddClaim(new Claim(ClaimTypes.Email, Email));
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Page()
        {
            return View();
        }

    }
}
