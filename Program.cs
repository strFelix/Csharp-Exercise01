using System;

namespace Atividade01
{
    class Program{

        static void Main(string[] args){
            
            Console.WriteLine("Digite um numero referente a opção desejada: ");
            Console.WriteLine("1 - Calcular Média");
            Console.WriteLine("2 - Calcular Tabuada");
            Console.WriteLine("3 - Detalhar Datas");
            Console.WriteLine("4 - Calcular INSS");
            Console.WriteLine("-----------------");

            int opção = int.Parse(Console.ReadLine());
            
            switch(opção){
                case 1:
                    CalcularMedia();
                    break;

                case 2:
                    CalcularTabuada();
                    break;

                case 3:
                    DetalharData();
                    break;

                case 4:
                    CalcularDescontoINSS();
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        
        public static void CalcularMedia(){
            Console.WriteLine("Digite a primeira nota: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if(media > 7){
                Console.WriteLine("Aprovado!");
            }
            else if(media < 7 && media >= 4){
                Console.WriteLine("Recuperação");
            }
            else{
                Console.WriteLine("Reprovado");
            }
        }
        
        public static void CalcularTabuada(){
            Console.WriteLine("Digite a tabuada que deseja calcular: ");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10){
                string mensagem = string.Format("{0} x {1} = {2}", tabuada, contador, tabuada * contador);
                Console.WriteLine(mensagem);
                contador++;
            }
        }
        
        public static void DetalharData(){
            Console.WriteLine("Digite uma data: ");
            string dataInput = Console.ReadLine();

            DateTime data = DateTime.ParseExact(dataInput, "dd/MM/yyyy", null);

            // transformando os valores de DateTime para String e separando seus fatores, dia da semana e mês.
            string diaSemana = data.ToString("dddd");
            string mes = data.ToString("MMMM");

            // comparando a data caso domingo
            if (data.DayOfWeek == DayOfWeek.Sunday){
                string horaAtual = DateTime.Now.ToString("HH:mm");
                Console.WriteLine("Este dia é um domingo do mês de {0}! A hora atual é: {1}.", mes, horaAtual);
            }
            else{
                Console.WriteLine("É um(a) {0} do mês de {1}.", diaSemana, mes);
            }
        }
        
        public static void CalcularDescontoINSS(){
            Console.WriteLine("Digite o salario para calcular o desconto: ");
            double salario = double.Parse(Console.ReadLine());

            if(salario <= 1212){
                salario *= 0.925;
            }
            else if(salario <= 2427.35){
                salario *= 0.91;
            }
            else if(salario <= 3641.03){
                salario *= 0.88;
            }
            else{
                salario *= 0.84;
            }

            Console.WriteLine("O valor do salario com o desconto é de: {0:c2}", salario);
        }
    }
}