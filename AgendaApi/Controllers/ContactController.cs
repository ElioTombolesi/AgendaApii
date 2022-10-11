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
        [Route("GetOne /{Id}")] // esto lo que hace es decir de donde obtine uno y eñ {} es para que puedas ingresasr el id que queres saber

        public IActionResult GetOneById(int Id)
        {
            List<Contact> usersToReturn = _ContactRepository.GetAllContact().Where(x => x.Id == Id).ToList();
            if (usersToReturn.Count > 0)
                return Ok(usersToReturn);

            return NotFound("Contacto inexistente");
        }
    }
}
