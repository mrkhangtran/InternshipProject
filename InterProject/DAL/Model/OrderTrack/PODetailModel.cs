using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InterProject.DAL.Model.OrderTrack
{
    public class PODetailModel
    {
<<<<<<< HEAD

=======
        [Key]
        [Required]
        [Display(Name = "Item Number")]
        [Range(0, 10 ^ 11 - 1)] //up to 10 digits
        public float ID { get; set; }

        //unknown
        public string Line { get; set; }

        [StringLength(255, ErrorMessage = "No more than 255 characters")]
        public string Description { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Warehouse { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Colour { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Size { get; set; }
        public string Item { get; set; }

        //unused
        public string CartonType { get; set; }
        public string CartonLength { get; set; }
        public string CartonWidth { get; set; }
        public string CartonDepth { get; set; }
        public string HI { get; set; }

        [Required]
        [Display(Name = "Item Quantity")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float Quantity { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float Cartons { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float Cube { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float KGS { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float UnitPrice { get; set; }

        //Item Quantity*Unit Price = Total Price *unfinished*
        public float TotalPrice { get; set; }

        [Required]
        [Display(Name = "Retail Price")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive number")]
        public float RetailPrice { get; set; }

        //Item Quantity*Retail Price = Total Retail Price *unfinished*
        public float TotalRetailPrice { get; set; }

        public float RetailCost { get; set; }

        [RegularExpression("[^0-9]", ErrorMessage = "Tariff must be numeric")]
        public string Tariff { get; set; }

        //unused
        public string PackType { get; set; }
        public float GridRow { get; set; }
>>>>>>> d391ab3fb752cd8541e5559ce64bf1cec8208d5d
    }
}