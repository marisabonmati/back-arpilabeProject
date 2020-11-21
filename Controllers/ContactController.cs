using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_arpilabeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back_arpilabeProject.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ContactController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]

        public ActionResult<List<Contact>> Get()
        {

            try
            {
                var listContact = _context.Contact.ToList();
                return Ok(listContact);
            }

            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]

        public ActionResult<Contact> Get(int id)
        {
            try
            {
                var contact = _context.Contact.Find(id);
                if(contact == null)
                {
                    return NotFound();
                }
                return Ok(contact);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // POST api/values
        [HttpPost]

        public ActionResult Post([FromBody] string contact)
        {
            try
            {
                _context.Add(contact);
                _context.SaveChanges();
                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Contact contact)
        {
            try
            {
                if(id != contact.Id)
                {
                    return BadRequest();
                }
                _context.Entry(contact).State = EntityState.Modified;
                _context.Update(contact);
                _context.SaveChanges();

                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var contact = _context.Contact.Find(id);
                if(contact == null)
                {
                    return NotFound();
                }

                _context.Remove(contact);
                _context.SaveChanges();

                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
