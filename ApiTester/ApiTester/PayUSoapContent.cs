using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPanther.Objects.BaseObjects
{
    public class PayUSoapContent
    {
        public string Api { get; set; }
        public Guid SafeKey { get; set; }
        public int TransactionType { get; set; }
        public bool Stage { get; set; }
        public string CancelUrl { get; set; }
        public Merchant Merchant { get; set; }
        public string ReturnUrl { get; set; }
        public Basket Basket { get; set; }
        public string SupportedPaymentMethod { get; set; }

    }
}
