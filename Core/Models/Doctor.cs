﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    public class Doctor : ApplicationUser
    {
        [Required]
        public int SpecializationId { set; get; }      
        
        public override string UserImage { get; set; }
        
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}