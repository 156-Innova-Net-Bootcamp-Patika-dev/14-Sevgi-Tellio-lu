using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteManagament.Core;
using SiteManagament.Core.Entity;
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

    public class ApartmentController : Controller
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
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var apartments = _service.GetAllAsync();
        //    return Ok(apartments);

        //}
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var apartments = _service.GetByIdAsync(id);
        //    if (apartments == null)
        //    {
        //        return Ok(apartments);
        //    }
        //    return NotFound();

        //}
        //[HttpPost]
        //public IActionResult Post([FromBody] Apartment apartment)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var addedApartment = _service.AddAsync(apartment);
        //        return CreatedAtAction("Get", new { id = addedApartment.Id }, addedApartment);
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState); //400+validation errors
        //    }


        //}


        //[HttpPut]
        //public IActionResult Put([FromBody] Apartment aparment)
        //{
        //    if (_service.UpdateAsync(aparment) != null)
        //    {
        //        return Ok(_service.UpdateAsync(aparment)); //200 + data
        //    }

        //    return NotFound();
        //}
        //[HttpDelete]
        //public IActionResult Delete(Apartment aparment)
        //{
        //    if (_service.DeleteAsync(aparment) != null)
        //    {
        //        _service.DeleteAsync(aparment); //200
        //        return Ok();
        //    }

        //    return NotFound(); //404 döndürecek

        //}
    }
    }

