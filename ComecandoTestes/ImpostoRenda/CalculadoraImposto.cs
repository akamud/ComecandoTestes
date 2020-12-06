using System.Threading.Tasks;

namespace ComecandoTestes.ImpostoRenda
{
    public class CalculadoraImposto
    {
        public async Task<decimal> CalcularSalarioLiquido(decimal salario)
        {
            var aliquota = await new ServicoImpostoRenda().ObterAliquota(salario);

            return salario - salario * aliquota / 100;
        }
    }
}