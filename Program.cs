using System;

namespace Fixação2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Fixação 2 ");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("Qual o tipo de Combustível que deseja abastecer? G - Gasolina ou A - Álcool? ");
            string tipo = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Digite aqui a quantidade que deseja abastecer: ");
            float litros = float.Parse(Console.ReadLine());
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            float resultadoFuncao;
            Console.WriteLine("----------------------------------------------------------------------------------");

            switch (tipo.ToLower())
            {
                case "a":
                    resultadoFuncao = ValorASerPago(litros, precoAlcool,0.03f, 0.05f);
                    Console.WriteLine($"O valor a ser pago é de: {resultadoFuncao}");
                    break;

                    case "g":
                    resultadoFuncao = ValorASerPago(litros, precoGasolina, 0.04f, 0.06f);
                    Console.WriteLine($"O valor a ser pago é de R$: {resultadoFuncao}");
                    break;
                     default:
                        Console.WriteLine("Valor Inválido");
                        break;
            }//fim
            
              float ValorASerPago(float litros, float preco, float perc1, float perc2){
                  float percentualDesconto;

                  if (litros <=20)
                  {
                      percentualDesconto = perc1;
                  } else{
                      percentualDesconto = perc2;
                  }
                  float totalDesconto = (litros * preco) * percentualDesconto;
                  float valorBruto = (litros * preco);
                  float valorAPagar = valorBruto - totalDesconto;
                  return valorAPagar;
              }
        }
    }
}
