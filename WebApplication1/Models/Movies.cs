using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace WebApplication1.Models
{
    [Table("Movies")]
    public class Movie
    {
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
    
    }


   
