﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }   
        [Required]
        public string? Email { get; set; }
        public string? LastName { get; set; }   // el signo es para que admita valores nulos 
        public string Password { get; set; }
        public ICollection<Contact>? Contacts{ get; set; }
}
}
