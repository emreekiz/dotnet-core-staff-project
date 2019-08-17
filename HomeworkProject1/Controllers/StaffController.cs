using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeworkProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkProject1.Controllers
{
    public class StaffController : Controller
    {
        
        public static List<Staff> staffs;
        public IActionResult Index()
        {
            List<Staff> staffList = Staff.GetSampleData();
            if (staffs != null && staffs.Any())
            {
                staffList.AddRange(staffs);
            }
            return View(staffList);
          
        }

        public IActionResult Detail(int id)
        {
            List<Staff> staffList = Staff.GetSampleData();
            if (staffs != null && staffs.Any())
            {
                staffList.AddRange(staffs);
            }
            Staff item = staffList.Where(x => x.Id == id).FirstOrDefault();
            return View(item);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff modelStaff)
        {
            if (ModelState.IsValid)
            {
                if (staffs==null)
                {
                    staffs=new List<Staff>();
                }
                staffs.Add(modelStaff);
                return RedirectToAction("Detail", new {id = modelStaff.Id});
            }

            return View(modelStaff);




        }
    }
}