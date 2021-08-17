﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(500)]
        public string AboutContent { get; set; }
        [StringLength(500)]
        public string AboutContent2 { get; set; }
        [StringLength(100)]
        public string AboutImage { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}