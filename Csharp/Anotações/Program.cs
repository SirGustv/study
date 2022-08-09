using System; //Importações -> Sempre definidas pelo "using", serve para definir quais bibliotecas/namespaces de código o programa irá usar.
using System.Globalization;
namespace Anotações //Divisões lógicas -> Normalmente acompanham o nome da pasta em que está. É um agrupamento de classes relacionadas.
{
    class Program //Unidade base da programação orientada a objetos (POO). Todo o código a ser escrito em C#, deve estar dentro de uma classe.
    {
        static void Main(string[] args) //Declaração padrão do C# para denominar o ponto de entrada da aplicação (aonde a execução começa).
        {
            //Saída de dados
            Console.WriteLine("Olá Mundo!"); //Comando de saída de texto. Imprime/exibe o texto na tela do usuário. Para que o texto seja exibido, é necessário ele ser digitado dentro das chaves. O texto a ser escrito deve estar dentro de aspas duplas.
            Console.Write("");//Outro modo de saída disponível. Este modo não quebra a linha igual o anterior.

            //Variáveis
            double num1 = 55.172;//A declaração de uma variável é composta por 'tipo' e 'nome'(Mais detalhes sobre quais tipos no arquivo 'Caderno CSharp'). A variável de tipo 'double' indica que o número tem um ponto flutuante.

            Console.WriteLine(num1);//Para exibir uma variável na saida de dados basta escreve-lá dentro dos parênteses(neste exemplo não há necessidade de aspas pois há somente uma variável sem texto a acompanhando)
            Console.WriteLine(num1.ToString("F1"));//Nesta saída, é feito um controle sobre a quantidade de casas decimais irão ser exibidas na saída(somente uma neste exemplo).
            Console.WriteLine(num1.ToString("F2", CultureInfo.InvariantCulture));//Nesta saída, além do controle de casas decimais, tambem é removido a variação de separador, deixando invariante o símbolo de separador '.'
        }
    }
}
