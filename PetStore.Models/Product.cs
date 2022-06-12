using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using PetStore.Common;

namespace PetStore.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(Validation.NAME_LEN)]
        public string Name { get; set; }
        [ForeignKey(nameof(ProductType))]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public bool IsAvaliable { get; set; }
        public decimal Price { get; set; }
        [MaxLength(Validation.DESCRIPTION_LEN)]
        public string Description { get; set; }
    }
}
