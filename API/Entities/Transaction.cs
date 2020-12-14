using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Transactions")]
    public class Transaction
    {
        public int Id { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string Line { get; set; }
        public decimal Discount { get; set; }
        public decimal TicketPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public TransportCard TransportCard { get; set; }
        public int TransportCardId { get; set; }
    }
}