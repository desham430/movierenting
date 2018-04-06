using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("MemberType")]
    public class MembershipType

    {
       [Key]
        public byte MembershipId { get; set; }

        public short SignupFee { get; set; }
        public byte Durationinmonths { get; set; }
        public byte Discountrate { get; set; }          
    }
}