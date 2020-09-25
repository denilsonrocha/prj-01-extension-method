namespace prj_01_extension_method.Services
{
    public class CalculoService : ICalculoService
    {
        public decimal dividir(decimal a, decimal b)
        {
            return (a == 0 || b == 0)? 0 :  a / b;
        }

        public decimal multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }
    }
}