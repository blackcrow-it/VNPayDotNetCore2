using System;
using System.ComponentModel.DataAnnotations;

namespace VNPay.Models
{
    public class OrderInfo
    {

        /// <summary>
        /// Merchant OrderId
        /// </summary>
        [Key]
        public string OrderId { get; set; }
        /// <summary>
        /// Payment amount
        /// </summary>
        public int Amount { get; set; }
        public string OrderDescription { get; set; }

        public string BankCode { get; set; }

        /// <summary>
        /// Order Status
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Creaed date
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// VNPAY Transaction Id
        /// </summary>
        public decimal vnp_TransactionNo { get; set; }
        public string vpn_Message { get; set; }
        public string vpn_TxnResponseCode { get; set; }
        
        
    }
}