using backEndTest.Data;
using backEndTest.Models;

namespace backEndTest.Services
{
    public class ProcessamentoService
    {
        private readonly CreditoService _creditoService;

        public ProcessamentoService(CreditoService creditoService, ApplicationDbContext context)
        {
            _creditoService = creditoService;
        }

        public Resultado Processar(Credito credito)
        {
            if (!_creditoService.ValidarValorCredito(credito.Valor))
            {
                return new Resultado { Status = "Recusado", Total = 0, Juros = 0 };
            }
            if (!_creditoService.ValidarQuantidadeParcelas(credito.Parcelas))
            {
                return new Resultado { Status = "Recusado", Total = 0, Juros = 0 };
            }
            if (!_creditoService.ValidarDataVencimento(credito.Vencimento))
            {
                return new Resultado { Status = "Recusado", Total = 0, Juros = 0 };
            }
            if (!_creditoService.ValidarValorMinimoParaPessoaJuridica(credito.Valor, credito.Tipo))
            {
                return new Resultado { Status = "Recusado", Total = 0, Juros = 0 };
            }

            decimal taxaJuros = Taxas(credito.Tipo);
            decimal valorJuros = credito.Parcelas * (credito.Valor * (taxaJuros / 100));
            decimal valorTotal = credito.Parcelas * (credito.Valor + valorJuros);

            var resultado = new Resultado
            {
                Status = "Aprovado",
                Total = valorTotal,
                Juros = valorJuros
            };

            return resultado;
        }

        private decimal Taxas(string tipoCredito)
        {
            switch (tipoCredito)
            {
                case "direto":
                    return 2;
                case "consignado":
                    return 1;
                case "pJuridica":
                    return 5;
                case "pFisica":
                    return 3;
                case "imobiliario":
                    return 9;
                default:
                    throw new ArgumentException("Tipo de crédito inválido.");
            }
        }
    }
}
