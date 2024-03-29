namespace backEndTest.Models
{
    public class Credito
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public string Tipo { get; set; }

        public int Parcelas { get; set; }

        public DateTime Vencimento { get; set; }
    }
}
