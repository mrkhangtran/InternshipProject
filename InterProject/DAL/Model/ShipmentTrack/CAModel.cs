using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterProject.DAL.Model.ShipmentTrack
{
    public class CAModel
    {
        public float ID { get; set; }
        public DateTime ArrivalDate { get; set; }
        [StringLength(20, ErrorMessage = "No more than 20 characters")]
        public string UpdatedBy { get; set; }
    }
}