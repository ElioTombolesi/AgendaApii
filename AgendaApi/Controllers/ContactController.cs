using AgendaApi.DTOs;
using AgendaApi.Entities;
using AgendaApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContactRepository _ContactRepository { get; set; }
        public ContactController(ContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ContactRepository.GetAllContact());
        }

        [HttpGet]
        [Route("GetOne/{Id}")] // esto lo que hace es decir de donde obtine uno y eñ {} es para que puedas ingresasr el id que queres saber

        public IActionResult GetOneById(int Id)
        {
            Contact contact = _ContactRepository.GetAllContact().Where(x => x.Id == Id).ToList().SingleOrDefault();
            var contactDTO = new ContacDTO();

            contactDTO.Id = contact.Id;
            contactDTO.Name = contact.Name;
            contactDTO.TelephoneNumber = contact.TelephoneNumber;
            contactDTO.CelularNumber = contact.CelularNumber;
            contactDTO.Description = contact.Description;
            return Ok(contactDTO);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            
            }
        
        }
    }
}
