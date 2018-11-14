using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int clientID { get; set; }
        [Required]
        public String clientFirstName { get; set; }
        [Required]
        public String clientLastName { get; set; }
        [Required]
        public String clientAddress { get; set; }
        [Required]
        public String clientCity { get; set; }
        [Required]
        public String clientState { get; set; }
        [Required]
        public String clientZip { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Bad email")]
        public String clientEmail { get; set; }
        [EmailAddress]
        [Compare("Email")]
        [Required]
        public string ConfirmEmail { get; set; }
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "PhoneNumber should contain only numbers")]
        public int clientPhone { get; set; }

    }
}