namespace backEndTest.Services
{
    public class CreditoService
    {
        public bool ValidarValorCredito(decimal valorCredito)
        {
            return valorCredito > 0 && valorCredito <= 1000000;
        }

        public bool ValidarQuantidadeParcelas(int quantidadeParcelas)
        {
            return quantidadeParcelas >= 5 && quantidadeParcelas <= 72;
        }

        public bool ValidarDataVencimento(DateTime dataVencimento)
        {
            DateTime dataMinima = DateTime.Now.AddDays(15);
            DateTime dataMaxima = DateTime.Now.AddDays(40);
            return dataVencimento >= dataMinima && dataVencimento <= dataMaxima;
        }

        public bool ValidarValorMinimoParaPessoaJuridica(decimal valorCredito, string tipoCredito)
        {
            return tipoCredito != "pJuridica" || valorCredito >= 15000;
        }
    }
}
