using System;

namespace ComecandoTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            Executar();
            // ConferirResultadosPrimeiraIteracao();
            // ConferirResultadosSegundaIteracao();
        }

        private static void Executar()
        {
            Console.WriteLine("Digite o primeiro número:");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            var operacao = Console.ReadLine();

            int resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = Calculadora.Somar(numero1, numero2);
                    break;
                case "-":
                    resultado = Calculadora.Subtrair(numero1, numero2);
                    break;
                case "/":
                    resultado = Calculadora.Dividir(numero1, numero2);
                    break;
                case "*":
                    resultado = Calculadora.Multiplicar(numero1, numero2);
                    break;
            }
            
            Console.WriteLine($"Resultado: {resultado}");
        }

        private static void ConferirResultadosPrimeiraIteracao()
        {
            var resultadoSoma = Calculadora.Somar(20, 30);
            Console.WriteLine($"Somar 20 + 30 = {resultadoSoma}");
            
            var resultadoSubtracao = Calculadora.Subtrair(30, 10);
            Console.WriteLine($"Somar 30 - 10 = {resultadoSubtracao}");
            
            var resultadoMultiplicacao = Calculadora.Multiplicar(20, 3);
            Console.WriteLine($"Somar 20 * 3 = {resultadoMultiplicacao}");
            
            var resultadoDivisao = Calculadora.Dividir(40, 4);
            Console.WriteLine($"Somar 40 / 4 = {resultadoDivisao}");
        }
        
        private static void ConferirResultadosSegundaIteracao()
        {
            var resultadoSoma = Calculadora.Somar(20, 30);
            Console.WriteLine($"Somar 20 + 30 deveria ser 50. {resultadoSoma == 50}");
            
            var resultadoSubtracao = Calculadora.Subtrair(30, 10);
            Console.WriteLine($"Subtrair 30 - 10 deveria ser 20. {resultadoSubtracao == 20}");
            
            var resultadoMultiplicacao = Calculadora.Multiplicar(20, 3);
            Console.WriteLine($"Multiplicar 20 * 3 deveria ser 60. {resultadoMultiplicacao == 60}");
            
            var resultadoDivisao = Calculadora.Dividir(40, 4);
            Console.WriteLine($"Dividir 40 / 4 deveria ser 10. {resultadoDivisao == 10}");
        }
    }
}