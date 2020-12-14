using System.Collections.Generic;

namespace API.DTOs
{
    public class TransportCardDto
    {
        public int Id { get; set; }
        public int CardType { get; set; }
        public decimal Load { get; set; }
        public ICollection<TransactionDto> Transactions { get; set; }
    }
}