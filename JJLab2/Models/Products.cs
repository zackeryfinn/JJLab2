using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JJLab2.Models
{
    public class Products
    {
        [Required]
        [MaxLength(8)]
        [DisplayName("Product ID")]
        public int ProdID { get; set; } = 00000000;

        [Required]
        [MaxLength(20)]
        [DisplayName("Product Name")]
        public string ProdName { get; set; } = "Default Name";

        [Required]
        [MaxLength(20)]
        [DisplayName("Product Description")]
        public string ProdDescription { get; set; } = "Defualt Description";

        [Required]
        [DisplayName("Product Price")]
        public decimal ProdPrice { get; set; } = 0;

        [MaxLength(3)]
        [DisplayName("Product Quantity")]
        public int ProdQuantity { get; set; } = 0;

   

    }
}