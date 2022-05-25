using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.RequestModel
{
    public class CustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerAddress { get; set; }
        public int? MobileNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
