using System;

namespace API.DTOs
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string Line { get; set; }
        public decimal Discount { get; set; }
        public decimal TicketPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}