using backEndTest.Data;
using backEndTest.Models;
using backEndTest.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backEndTest.Repository
{
    public class ResultadoRepository : IResultadoRepository
    {
        private readonly ApplicationDbContext _context;

        public ResultadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Resultado>> GetAllResultados()
        {
            return await _context.Resultados.ToListAsync();
        }

        public async Task<Resultado> GetResultadoById(int id)
        {
            return await _context.Resultados.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Resultado> SaveResultado(Resultado resultado)
        {
            await _context.Resultados.AddAsync(resultado);
            await _context.SaveChangesAsync();

            return resultado;
        }
    }
}
