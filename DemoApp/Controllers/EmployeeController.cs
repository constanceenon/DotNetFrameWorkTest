using DemoApp.Models;
using DemoApp.Repository;
using DemoApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApp.Controllers
{
    //[Route("api/[controller]")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeRepository _employeeRepo;
        public EmployeeController()
        {
            _employeeRepo = new EmployeeRepository(); 
        }

        [Route("api/employee/CreateNewEmployee")]
        [HttpPost]
        public HttpResponseMessage CreateNewEmployee(Employee model)
        {
            try
            {
                int employee = _employeeRepo.CreateEmployee(model);
                return Request.CreateResponse(HttpStatusCode.OK, employee);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        [Route("api/employee/UpdateEmployee")]
        [HttpPut]
        public HttpResponseMessage UpdateEmployee(Employee model)
        {
            try
            {
                int employee = _employeeRepo.UpdateEmployee(model);
                return Request.CreateResponse(HttpStatusCode.OK, employee);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        [Route("api/employee/getemployeee{id}")]
        [HttpGet]
        public HttpResponseMessage GetEmployee(int id)
        {
            try
            {
                var employee = _employeeRepo.GetEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, employee);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }

        }
        [Route("api/employee/DeleteEmployee{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            try
            {
                bool employee = _employeeRepo.DeleteEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, employee);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/employee/getallemployees")]
        [HttpGet]
        public HttpResponseMessage GetAllEmployees()
        {
            try
            {
                var list = _employeeRepo.GetAllEmployees();
                return Request.CreateResponse(HttpStatusCode.OK, list);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }

        }
    }
}
