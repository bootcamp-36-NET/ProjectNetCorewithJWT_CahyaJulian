﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCore.Configuration;
using LearnNetCore.Context;
using LearnNetCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LearnNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly MyContext _context;
        public EmployeesController(MyContext myContext, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._context = myContext;
        }
        [HttpGet]
        public async Task<List<EmployeeVM>> GetAll()
        {
            var getData = await this._context.employees.Include("Users").Where(Q => Q.isDelete == false).ToListAsync();
            List<EmployeeVM> list = new List<EmployeeVM>();
            foreach (var employee in getData)
            {
                EmployeeVM emp = new EmployeeVM()
                {
                    EmployeeId = employee.Users.Id,
                    Username = employee.Users.UserName,
                    Phone = employee.Users.PhoneNumber,
                    CreateDate = employee.CreateDate,
                    UpdateDate = employee.UpdateDate,
                    DeleteDate = employee.DeleteDate
                };
                list.Add(emp);
            }
            return list;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                var getData = _context.employees.Include("Users").SingleOrDefault(x => x.Id == id);
                if (getData == null)
                {
                    return BadRequest("Please try again. Delete canceled.");
                }

                getData.DeleteDate = DateTimeOffset.Now;
                getData.isDelete = true;


                _context.Entry(getData).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok("Deleted successfully");
            }
            return Ok("Failed");

        }
        [HttpGet("char")]
        public async Task<List<ChartVM>> LoadChar()
        {
            //var dep = new Division();
            var data = await _context.divisions.Include("Department").Select(j => j.DepartmentId).Distinct().ToListAsync();
            var success = _context.divisions
                .Where(j => j.Department.Name == "Add")
                .GroupBy(j => j.DepartmentId)
                .Select(group => new {
                    DepartmentId = group.Key,
                    Count = group.Count()
                });
            var countSuccess = success.Select(a => a.Count).ToList();
            var exception = _context.divisions
                .Where(j => j.Department.Name == "Development")
                .GroupBy(j => j.DepartmentId)
                .Select(group => new {
                    DepartmentId = group.Key,
                    Count = group.Count()
                });
            var countException = exception.Select(a => a.Count).ToList();
            //var total = new ChartVM
            //{
            //    CountA = countSuccess.First(),
            //    CountB = countException.First()
            //};
            List<ChartVM> list = new List<ChartVM>();
            //foreach (var employee in data)
            //{
                var total = new ChartVM
                {
                    CountA = countSuccess.First(),
                    CountB = countException.First()
                };
                list.Add(total);
        //}
            return list;
            //return new JsonResult(new { myData = data, mySuccess = countSuccess, myException = countException });
            //return new JsonResult(total);
        }
    }
}
