using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ITransportCardRepository
    {
        void Update(TransportCard transportCard);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<TransportCard>> GetTransportCardsAsync();
        Task<TransportCard> GetTransportCardByIdAsync(int id);
    }
}