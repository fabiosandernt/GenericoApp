namespace GenericoApp.Domain.FolhaPagamento.ValueObjects
{
    public class DetalhesPagamento
    {
        public decimal SalarioBruto { get; private set; }
        public decimal Impostos { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal SalarioLiquido { get; private set; }
        public decimal Adicionais { get; private set; }
    }
}