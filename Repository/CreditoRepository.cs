using backEndTest.Data;
using backEndTest.Models;
using backEndTest.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backEndTest.Repository
{
    public class CreditoRepository : ICreditoRepository
    {
        private readonly ApplicationDbContext _context;

        public CreditoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Credito>> GetAllCreditos()
        {
            return await _context.Creditos.ToListAsync();
        }

        public async Task<Credito> GetCreditoById(int id)
        {
            return await _context.Creditos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Credito> SaveCredito(Credito credito)
        {
            await _context.Creditos.AddAsync(credito);
            await _context.SaveChangesAsync();

            return credito;
        }
    }
}
