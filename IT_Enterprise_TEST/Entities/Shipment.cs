using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_TEST.Entities
{
    public class Shipment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Organization { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Manager { get; set; }
        public int Quantity { get; set; }
        public decimal Sum { get; set; }
    }
}
