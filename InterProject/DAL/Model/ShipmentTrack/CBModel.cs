using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterProject.DAL.Model.ShipmentTrack
{
    public class CB
    {
        [Key]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, float.MaxValue, ErrorMessage = "ID must be numberic")]
        public float ID { get; set; }
        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Order { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Line { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No more than 50 characters")]
        public string Item { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Carier { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string Vessel { get; set; }

        public DateTime ETD { get; set; }
        public DateTime ETA { get; set; }
        public string Voyage { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be numberic")]
        public int Quantity { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, int.MaxValue, ErrorMessage = "Cartoons must be numberic")]
        public int Cartoons { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Cube must be numberic")]
        public decimal Cube { get; set; }

        [StringLength(50, ErrorMessage = "No more than 50 characters")]
        public string PackType { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string OriginPort { get; set; }

        [StringLength(30, ErrorMessage = "No more than 30 characters")]
        public string DestinationPort { get; set; }
        public string Loading { get; set; }
        public string LoadRef { get; set; }
        public string Mode { get; set; }
        public string FreightTerms { get; set; }

        [StringLength(50, ErrorMessage = "No more than 50 characters")]
        public string Consignee { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99,ErrorMessage ="GrossWeight must be numberic")]
        public decimal GrossWeight { get; set; }

        public DateTime BookingDate { get; set; }
        public string BookingType { get; set; }

    }
}