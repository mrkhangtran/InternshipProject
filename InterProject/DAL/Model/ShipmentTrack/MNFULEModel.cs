using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterProject.DAL.Model.ShipmentTrack
{
    public class MNFULE
    {
        public float ID { get; set; }
        public string Seal { get; set; }
        public string Container { get; set; }
        public string Loading { get; set; }
        public int Bars { get; set; }
        public string Equipment { get; set; }
        public int Quantity { get; set; }
        public string Cartons { get; set; }
        public decimal Cube { get; set; }
        public decimal KGS { get; set; }
        public string FreightTerms { get; set; }
        public decimal ChargeableKGS { get; set; }
        public string PackType { get; set; }
        public decimal NetKGS { get; set; }
        public float GridRow { get; set; }


    }
}