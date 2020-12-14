using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TransportCardRepository : ITransportCardRepository
    {
        private readonly DataContext _context;
        public TransportCardRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<TransportCard> GetTransportCardByIdAsync(int id)
        {
            return await _context.TransportCard.FindAsync(id);
        }

        public async Task<IEnumerable<TransportCard>> GetTransportCardsAsync()
        {
            return await _context.TransportCard
                .Include(p => p.Transactions)
                .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(TransportCard transportCard)
        {
            _context.Entry(transportCard).State = EntityState.Modified;
        }
    }
}