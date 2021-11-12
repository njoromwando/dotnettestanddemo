using System;
using Microsoft.VisualBasic;

namespace ACME.BL
{
    public class Order
    {
        public DateTimeOffset? OrderDate { get; set; }
        public string Address { get; set; }

        public bool Validate()
        {
            return true;
        }
        public bool Retrieve()
        {
            return true;
        }
        public bool Save()
        {
            return true;
        }
    }
}