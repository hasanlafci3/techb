using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace TechbWebApi.Controllers
{

    public class BasicEmployee
    {       
        [StringLength(maximumLength: 250, MinimumLength = 10)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Phone is not valid.")]
        public string Phone { get; set; }

        [Range(minimum: 30, maximum: 400, ErrorMessage = "Hourly salary does not fall within allowed range.")]
        public decimal HourlySalary { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class BasicEmployeeController : ControllerBase
    {
        [HttpPost]
        public BasicEmployee Post([FromBody] BasicEmployee employee)
        {

            if (string.IsNullOrEmpty(employee.Name)  || employee.Name.Length < 10 || employee.Name.Length > 250)
            {
                throw new Exception("Name is not valid.");
            }

            return employee;
        }
    }



}
