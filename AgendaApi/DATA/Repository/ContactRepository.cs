using AgendaApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Repository
{
    
    public class ContactRepository : ControllerBase
    {
        public static List<Contact> FakeContact = new List<Contact>() // manera de crear contactos..
        {
            new Contact()
            {
                Name = "Pedd",
                Id = 1,
                CelularNumber = 343212345533


            },

            new Contact()
            {
                Name = "Carlos",
                Id = 2,
                CelularNumber = 5432135334


            }

        };
        public List<Contact> GetAllContact()
        {
            return FakeContact;
        }
    }
}
