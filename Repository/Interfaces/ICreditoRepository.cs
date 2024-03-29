using backEndTest.Models;

namespace backEndTest.Repository.Interfaces
{
    public interface ICreditoRepository
    {
        Task<List<Credito>> GetAllCreditos();
        Task<Credito> GetCreditoById(int id);
        Task<Credito> SaveCredito(Credito credito);
    }
}
