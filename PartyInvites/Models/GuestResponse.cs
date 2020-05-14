using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace PartyInvites.Models
{
    public class GuestResponse
    {
       // F i e l d s ( I n s t a n c e  V a r i a b l e s )

        [Required(ErrorMessage = "Name is required, Pally")]
        public string Name { get; set; } //gives you a getter and a setter method

        [Required(ErrorMessage = "Email is required, Pally")]
        [RegularExpression (".+\\@.+\\..+", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required, Pally")]
        public string Phone { get; set; }

        public bool? WillAttend { get; set; }  //true/false, has a question mark changes to true/false/null, can be null
    }
}

