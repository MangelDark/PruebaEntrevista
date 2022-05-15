using Domain.Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Layer.CustomerService;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private  ICustomerService service;

        public CustomerController(ICustomerService _service)
        {
            service = _service;
        }
        // GET: api/<CustomerController>
        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result = service.GetAllCustomer();
            if (result is not null)
            {
                return Ok(result);
            }
           return Ok("Not data.");
        }

        // GET api/<CustomerController>/5
        [HttpGet(nameof(GetById))]
        public IActionResult GetById(int id)
        {
            var result = service.GetCustomer(id);
            if(result is not null)
            {
                return Ok(result);

            }
            return Ok("Not record found");
        }

        // GET api/<CustomerController>/5
        [HttpGet(nameof(EmailExist))]
        public IActionResult EmailExist(string email)
        {
            var result = service.EmailExist(email);
            return Ok(result);
        }

        // POST api/<CustomerController>
        [HttpPost(nameof(Insert))]
        public IActionResult Insert([FromBody] Customer entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Ok(ModelState.Values);
                }
                service.InsertCustomer(entity);
                return Ok("Data Inserted.");

            }
            catch (Exception ex)
            {

                return Ok(ex.Message);
            }
          
        }

        // PUT api/<CustomerController>/5
        [HttpPut(nameof(Update))]
        public IActionResult Update([FromBody] Customer entity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Ok(ModelState.Values);
                }
                service.UpdateCustomer(entity);
                return Ok("Data updated.");
            }
            catch (Exception e)
            {

                return Ok(e.Message);
            }
          
             
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int id)
        {
            try
            {

                service.DeleteCustomer(id);
                return Ok("Data deleted");
            }
            catch (Exception e)
            {

                return Ok(e.Message);
            }
           
          
        }
    }
}
