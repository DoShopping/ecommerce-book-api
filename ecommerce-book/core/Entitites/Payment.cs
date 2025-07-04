using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entitites
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int OrderId { get; set; }

        public string PaymentGateway { get; set; }

        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;

        public string TransactionId { get; set; }

        public decimal PaidAmount { get; set; }

        public DateTime? PaidAt { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
