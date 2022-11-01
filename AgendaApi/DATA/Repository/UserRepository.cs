using AgendaApi.DATA;
using AgendaApi.DTOs;
using AgendaApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Repository
{
    
    public class UserRepository : ControllerBase

    {
        private AgendaApiContext _context;
        private readonly IMapper _mapper;
        public UserRepository(AgendaApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public static List<User> FakeUsers = new List<User>()
        {

            new User()
            {
               Email = "gdfgfdg@dfdssd.com",
               Name = "Lalo",
               Password = "pass",
               Id = 1,


            },
            new User()
            {
               Email = "yyyyyltr@htre.com",
               Name = "Pedro",
               Password = "pass2",
               Id=2,

            },
        };

        public List<User> GetAllUsers()
        {
            return FakeUsers;
        }

        public User? Validate(string user, string password)
        {
            return FakeUsers.SingleOrDefault(x => x.UserName == user && x.Password == password);
        }

        public void Archive(int id)

        {
            User user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {


            }
            return
            _context.Users.Update;

        }
    }

}
