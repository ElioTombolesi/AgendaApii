using AgendaApi.DTOs;
using AgendaApi.Entities;
using AgendaApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {   
         
        private readonly UserRepository _userRepository;
        private readonly IConfiguration _config;

        public UserController(UserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }
        

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_userRepository.GetAllUsers()); // retorna el 200 que es el ok y la tista de fake users.
        }

        [HttpGet]
        [Route("GetOne/{Id}")]

        public IActionResult GetOneById(int Id)
        {
            List<User> usersToReturn = _userRepository.GetAllUsers().Where(x => x.Id == Id).ToList();
            if (usersToReturn.Count > 0)
                return Ok(usersToReturn);

            return NotFound("Usuario inexistente");
            
        }

         [HttpDelete]
         
         public IActionResult DeleteUser(int id )
        {

            try 
            {

                _userRepository.Archive(id);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            
            }
        }


    }
}

