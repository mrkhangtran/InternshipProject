using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterProject.DAL.Model.ShipmentTrack
{
    public class AODModel
    {
        public float ID { get; set; }
        public string Carrier { get; set; }
        public string Vessel { get; set; }
        public string Voyage { get; set; }
        public DateTime CTD { get; set; }
        public DateTime ETA { get; set; }
        public string OriginPort { get; set; }
        public string DestinationPort { get; set; }
        public string Mode { get; set; }
        public string Confirmed { get; set; }

    }
}