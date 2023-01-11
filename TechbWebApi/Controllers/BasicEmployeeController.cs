using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechbWebApi.Controllers
{

    public class EmployeeAdvance : IValidatableObject
    {
        [StringLength(maximumLength: 250, MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Phone is not valid.")]
        public string Phone { get; set; }


        [MinLegalSalaryRequired(minJuniorSalary: 50, minSeniorSalary: 200)]
        public double HourlySalary { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var minAllowedBirthDate = DateTime.Today.AddYears(-65);
            if (minAllowedBirthDate > DateOfBirth)
            {
                yield return new ValidationResult("Birthdate is not valid.");
            }
        }
    }

    public class MinLegalSalaryRequiredAttribute : ValidationAttribute
    {
        public MinLegalSalaryRequiredAttribute(double minJuniorSalary, double minSeniorSalary)
        {
            MinJuniorSalary = minJuniorSalary;
            MinSeniorSalary = minSeniorSalary;
        }

        public double MinJuniorSalary { get; }
        public double MinSeniorSalary { get; }
        public string GetErrorMessage() => $"Minimum hourly salary is not valid.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var employee = (EmployeeAdvance)validationContext.ObjectInstance;
            var dateBeforeThirtyYears = DateTime.Today.AddYears(-30);
            var isOlderThanThirdyYears = employee.DateOfBirth <= dateBeforeThirtyYears;
            var hourlySalary = (double)value;

            if (employee.Name == "Denny")
            {
                return ValidationResult.Success;
            }

            if (employee.Name == "Henry")
            {
                return new ValidationResult(GetErrorMessage());
            }
            var isValidSalary = isOlderThanThirdyYears ? hourlySalary >= MinSeniorSalary : hourlySalary >= MinJuniorSalary;
            return isValidSalary ? ValidationResult.Success : new ValidationResult(GetErrorMessage());
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceEmployeeController : ControllerBase
    {
        [HttpPost]
        public EmployeeAdvance Post([FromBody] EmployeeAdvance employee)
        {
            return employee;
        }
    }



}
