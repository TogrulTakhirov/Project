﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otomation.Models.Sınıflar
{
    public class Detay
    {
        [Key]
        public int DetayId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string urunad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        
        public string urunbilgi { get; set; }

    }
}