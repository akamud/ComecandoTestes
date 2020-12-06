using ComecandoTestes.ImpostoRenda;
using System;
using System.Threading.Tasks;

namespace ComecandoTestes
{
    class Program
    {
        private static Calculadora calculadora;
        
        static async Task Main(string[] args)
        {
            calculadora = new Calculadora();
            
            // Executar();
            // ConferirResultadosPrimeiraIteracao();
            // ConferirResultadosSegundaIteracao();

            await ExecutarCalculoSalario();
        }

        private static void Executar()
        {
            Console.WriteLine("Digite o primeiro número:");
            var numero1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            var numero2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            var operacao = Console.ReadLine();

            var resultado = 0m;
            switch (operacao)
            {
                case "+":
                    resultado = calculadora.Somar(numero1, numero2);
                    break;
                case "-":
                    resultado = calculadora.Subtrair(numero1, numero2);
                    break;
                case "/":
                    resultado = calculadora.Dividir(numero1, numero2);
                    break;
                case "*":
                    resultado = calculadora.Multiplicar(numero1, numero2);
                    break;
            }
            
            Console.WriteLine($"Resultado: {resultado}");
        }

        private static void ConferirResultadosPrimeiraIteracao()
        {
            var resultadoSoma = calculadora.Somar(20, 30);
            Console.WriteLine($"Somar 20 + 30 = {resultadoSoma}");
            
            var resultadoSubtracao = calculadora.Subtrair(30, 10);
            Console.WriteLine($"Subtrair 30 - 10 = {resultadoSubtracao}");
            
            var resultadoMultiplicacao = calculadora.Multiplicar(20, 3);
            Console.WriteLine($"Multiplicar 20 * 3 = {resultadoMultiplicacao}");
            
            var resultadoDivisao = calculadora.Dividir(40, 4);
            Console.WriteLine($"Dividir 40 / 4 = {resultadoDivisao}");
        }
        
        private static void ConferirResultadosSegundaIteracao()
        {
            var resultadoSoma = calculadora.Somar(20, 30);
            Console.WriteLine($"Somar 20 + 30 deveria ser 50. {resultadoSoma == 50}");
            
            var resultadoSubtracao = calculadora.Subtrair(30, 10);
            Console.WriteLine($"Subtrair 30 - 10 deveria ser 20. {resultadoSubtracao == 20}");
            
            var resultadoMultiplicacao = calculadora.Multiplicar(20, 3);
            Console.WriteLine($"Multiplicar 20 * 3 deveria ser 60. {resultadoMultiplicacao == 60}");
            
            var resultadoDivisao = calculadora.Dividir(40, 4);
            Console.WriteLine($"Dividir 40 / 4 deveria ser 10. {resultadoDivisao == 10}");
        }

        private static async Task ExecutarCalculoSalario()
        {
            Console.WriteLine("Digite o salário:");
            var salario = decimal.Parse(Console.ReadLine());
            var resultadoSalario = await (new CalculadoraImposto().CalcularSalarioLiquido(salario));
            Console.WriteLine($"Salário Líquido: {resultadoSalario}");
        }
    }
}