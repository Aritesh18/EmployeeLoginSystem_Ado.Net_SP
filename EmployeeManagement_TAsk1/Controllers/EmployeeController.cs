﻿using EmployeeManagement_TAsk1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeManagement_TAsk1.Controllers
{
 
    public class EmployeeController : Controller
    {

        private static string connectionString = "";
        private readonly IAuthenticationService _authenticationService;
        public EmployeeController(IConfiguration configuration, IAuthenticationService authenticationService)
        {
            connectionString = configuration.GetConnectionString("Con");
            _authenticationService = authenticationService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            //    IEnumerable<Employee> employees = GetAllEmployee();
            //    return View(employees);

            IEnumerable<Employee> employees = GetAllEmployee();
            string jsonData = JsonConvert.SerializeObject(employees);
            ViewBag.EmployeeData = jsonData;
            return View(employees);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> lstEmployee = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(rdr["Id"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Mobile = rdr["Mobile"].ToString();
                    employee.Address = rdr["Address"].ToString();

                    lstEmployee.Add(employee);
                }
                con.Close();
            }
            return lstEmployee;
        }
        //[HttpGet]
        //[Authorize]
        //public IActionResult Index(int pageIndex = 1, int pageSize = 5)
        //{
        //    IEnumerable<Employee> employees = GetAllEmployee(pageIndex, pageSize);
        //    string jsonData = JsonConvert.SerializeObject(employees);
        //    ViewBag.EmployeeData = jsonData;

        //    // Pass pagination information to the view
        //    ViewBag.PageIndex = pageIndex;
        //    ViewBag.PageSize = pageSize;

        //    return View(employees);
        //}

        //public IEnumerable<Employee> GetAllEmployee(int pageIndex, int pageSize)
        //{
        //    List<Employee> lstEmployee = new List<Employee>();
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        // Add pagination parameters
        //        cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
        //        cmd.Parameters.AddWithValue("@PageSize", pageSize);

        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            Employee employee = new Employee();
        //            employee.Id = Convert.ToInt32(rdr["Id"]);
        //            employee.FirstName = rdr["FirstName"].ToString();
        //            employee.LastName = rdr["LastName"].ToString();
        //            employee.Email = rdr["Email"].ToString();
        //            employee.Mobile = rdr["Mobile"].ToString();
        //            employee.Address = rdr["Address"].ToString();

        //            lstEmployee.Add(employee);
        //        }
        //        con.Close();
        //    }
        //    return lstEmployee;
        //}

        public Employee GetEmployeeById(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(rdr["Id"]);
                    employee.FirstName = rdr["FirstName"].ToString();
                    employee.LastName = rdr["LastName"].ToString();
                    employee.Email = rdr["Email"].ToString();
                    employee.Mobile = rdr["Mobile"].ToString();
                    employee.Address = rdr["Address"].ToString();

                    con.Close();
                    return employee;
                }
            }
            return null;
        }

        public ViewResult Create()
        {
            return View();
    }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Employee employee = GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                cmd.Parameters.AddWithValue("@Address", employee.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Employee employee = GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spLoginUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@Action", "login");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var claims = new List<Claim>
                                {
                                     new Claim(ClaimTypes.Name, reader["UserName"].ToString()),
                                  new Claim(ClaimTypes.Role,  reader["Role"].ToString()),

                                };
                                var claimsIdentity = new ClaimsIdentity(
                            claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                                _authenticationService.SignInAsync(HttpContext, CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties { IsPersistent = true });
                                return RedirectToAction("Index", "Home");
                            }


                        }
                    }

                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(user);



        }
        [HttpPost]
        public ActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Employee");
        }
//        [HttpPost]
//        public IActionResult Create(Employee employee)
//        {
//            // Your code for creating a new employee
//            return RedirectToAction("Index");
//        }

//        //public IActionResult Update(int id)
//        //{
//        //    // Your code for retrieving and showing the employee details in the view
//        //}

//        [HttpPost]
//        public IActionResult Update(Employee employee)
//        {
//            // Your code for updating the employee
//            return RedirectToAction("Index");
//        }

//        //public IActionResult Delete(int id)
//        //{
//        //    // Your code for retrieving and showing the employee details in the view
//        //}

//        [HttpPost]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            // Your code for deleting the employee
//            return RedirectToAction("Index");
//        }




   }
}