using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterProject.DAL.Model.OrderTrack
{
    public class ProgressCheckModel
    {
        public float ID { get; set; }
        public string Complete { get; set; }
        public string onSchedule { get; set; }
        public DateTime IntendedShipDate { get; set; }
        public int EstQtyToShip { get; set; }
        public DateTime InspectionDate { get; set; }
        public string COMMENTS { get; set; }
    }
}