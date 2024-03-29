using backEndTest.Data;
using backEndTest.Models;
using backEndTest.Repository;
using backEndTest.Repository.Interfaces;
using backEndTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEndTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditoController : ControllerBase
    {
        private readonly ICreditoRepository _creditorepository;
        private readonly IResultadoRepository _resultadoRepository;
        private readonly ProcessamentoService _processamento;

        public CreditoController(ICreditoRepository creditoRepository, IResultadoRepository resultadoRepository,ProcessamentoService processamento)
        {
            _creditorepository = creditoRepository;
            _resultadoRepository = resultadoRepository;
            _processamento = processamento;
        }

        [HttpGet]
        public async Task<ActionResult<List<Credito>>> GetCreditos()
        {
            List<Credito> creditos = await _creditorepository.GetAllCreditos();
            return Ok(creditos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Credito>> GetCreditosById(int id)
        {
            Credito credito = await _creditorepository.GetCreditoById(id);
            if (credito == null)
            {
                return NotFound();
            }
            return Ok(credito);
        }

        [HttpPost]
        public async Task<ActionResult<Credito>> SaveCreditos([FromBody] Credito credito)
        {
            Resultado resultado = _processamento.Processar(credito);
            if (resultado.Status == "Aprovado")
            {
                Credito credito_saved = await _creditorepository.SaveCredito(credito);
                await _resultadoRepository.SaveResultado(resultado);

                return Ok(credito_saved);
            }
            else
            {
                return BadRequest(resultado);
            }

        }
    }
}
