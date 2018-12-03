using System;
using System.ComponentModel.DataAnnotations;

namespace InterProject.DAL.Model.OrderTrack
{
    public class POModel
    {
        [Required]
        [Display(Name = "PO Number")]
        [Range(0, 10 ^ 11 - 1)] //up to 10 digits
        //[IDValidation] //Validate Uniqueness
        public float ID { get; set; }

        public string Order { get; set; }

        private DateTime defaultOrderDate = DateTime.Now;

        //Default value is Current Date *unfinished*
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate
        {
            get
            {
                return defaultOrderDate;
            }
            set
            {
                defaultOrderDate = value;
            }
        }
        //public DateTime OrderDate { get; set; } = DateTime.Now;

        //Company
        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Supplier { get; set; }

        //Droplist Vietnam-HongKong
        [Required]
        public string Origin { get; set; }

        [Required]
        [Display(Name = "Port of Loading")]
        public string PortOfLoading { get; set; }

        [Required]
        [Display(Name = "Port of Delivery")]
        //[PoDeliveryValidation] // *unfinished*
        public string PortOfDelivery { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Buyer { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Department { get; set; }
        public string OrderType { get; set; }

        //Droplist from 2010 to 2020
        public string Season { get; set; }
        public string Factory { get; set; }

        //Default value = USD
        public string Currency { get; set; } = "USD";
        public DateTime ShipDate { get; set; }
        public DateTime LatestShipDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string LoadType { get; set; }
        public string Mode { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Vendor { get; set; }
    }
}