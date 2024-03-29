using backEndTest.Models;

namespace backEndTest.Repository.Interfaces
{
    public interface IResultadoRepository
    {
        Task<List<Resultado>> GetAllResultados();
        Task<Resultado> GetResultadoById(int id);
        Task<Resultado> SaveResultado(Resultado resultado);
    }
}
