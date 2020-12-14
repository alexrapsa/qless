using System.Collections;
using System.Collections.Generic;

namespace API.Entities
{
    public class TransportCard
    {
        public int Id { get; set; }
        public int CardType { get; set; }
        public decimal Load { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}