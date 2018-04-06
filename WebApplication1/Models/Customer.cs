using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("customers")]
    public class Customer
    
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        public MembershipType membershiptype { get; set; }
        public byte MembershipId { get; set; }          
    }

}