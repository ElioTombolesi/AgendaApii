namespace AgendaApi.DTOs
{
    public class UserForCreationDTO
    {

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string? LastName { get; set; }   // el signo es para que admita valores nulos 
            public string Password { get; set; }
            
        }
    }
}
