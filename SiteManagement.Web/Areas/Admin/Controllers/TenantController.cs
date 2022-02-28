using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SiteManagament.Core;
using SiteManagament.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteManagement.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area(nameof(Admin))]
    [Route(nameof(Admin) + "/[controller]")]
    public class TenantController : Controller
    {

            public IActionResult Index()
            {
           
               return View();
             }


        [HttpPost]
        public IActionResult Post([FromBody] Tenant tenant)
        {

            return View();
        }


    }
}
