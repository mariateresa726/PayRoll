using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayRollV1.Models;

namespace PayRollV1.Controllers
{
    public class HomeController : Controller
    {

       

        static List<Employee> employeeList = new List<Employee>();
        public IActionResult Index()
        {


            List<Employee> employeeList1 = new List<Employee>();
            string Query1 = "select employee_id,name,age,gender,phone,email,designation,employee.designation_id from employee inner join designation on employee.designation_id = designation.designation_id";
            SqlDataReader reader = SqlDBOperation.Query(Query1);

            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmpID = reader.GetInt32(0);
                emp.Name = reader.GetString(1);
                emp.Age = reader.GetInt32(2);
                emp.Gender = reader.GetString(3);
                emp.Phone = reader.GetString(4);
                emp.Email = reader.GetString(5);
                emp.DesignationName = reader.GetString(6);
                emp.DesignationID = reader.GetInt32(7);

                employeeList1.Add(emp);




            }

            employeeList = employeeList1;
            return View(employeeList1);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee collection)
        {

            SqlDBOperation.AddEmployee(collection);
            employeeList.Add(collection);
            return RedirectToAction("/Index", employeeList);
        }
        [HttpGet]
        public ActionResult Edit(int id)

        {

            var employee = new Employee();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (id == employeeList[i].EmpID)
                {
                    employee = employeeList[i];
                }
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(int id, Employee collection)

        {

            SqlDBOperation.Update(collection);
            employeeList.Add(collection);

            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)

        {

            var employee = new Employee();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (id == employeeList[i].EmpID)
                {
                    employee = employeeList[i];
                }
            }
            return View(employee);

        }
        [HttpPost]

        public ActionResult Delete(Employee collection)
        {
            SqlDBOperation.Delete(collection.EmpID);

            return RedirectToAction("Index");

        }


        public ActionResult Details(int id)
        {

            var employee = new Employee();
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (id == employeeList[i].EmpID)
                {
                    employee = employeeList[i];
                }
            }
            return View(employee);

        }

       


    }
}
