using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class CustomerE
    {
        public CustomerE()
        {
            Selling = new HashSet<SellingE>();
            SellingPayment = new HashSet<SellingPaymentE>();
            Service = new HashSet<ServiceE>();
            ServiceDevice = new HashSet<ServiceDeviceE>();
            ExpenseTransportation = new HashSet<ExpenseTransportationE>();
            CustomerPhone = new HashSet<CustomerPhoneE>();
        }

        public int CustomerEId { get; set; }
        public string OrganizationName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal ReturnAmount { get; set; }
        public decimal Paid { get; set; }
        public decimal AccountTransactionCharge { get; set; }
        public decimal Due { get; set; }
        public decimal PurchaseAdjustedAmount { get; set; }
        public decimal DueLimit { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime InsertDate { get; set; }
        public string Designation { get; set; } = string.Empty;
        public bool IsIndividual { get; set; }
        
        public virtual ICollection<SellingE> Selling { get; set; }
        public virtual ICollection<SellingPaymentE> SellingPayment { get; set; }
        public virtual ICollection<ServiceE> Service { get; set; }
        public virtual ICollection<ServiceDeviceE> ServiceDevice { get; set; }
        public virtual ICollection<CustomerPhoneE> CustomerPhone { get; set; }
        public virtual ICollection<ExpenseTransportationE> ExpenseTransportation { get; set; }
    }
}
