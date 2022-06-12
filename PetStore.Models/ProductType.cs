﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetStore.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
