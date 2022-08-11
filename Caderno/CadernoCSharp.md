## CADERNO DE ANOTAÇÕES CSHAP (.NET C#)

### ESTRUTURA BASE

```c#
using System;

namespace Exemplo
{
	class Progran
	{
    	static void Main(string[] args)
        {
            Console.WriteLine("Hello World!")
        }
	}    
}
```

A estrutura base de uma aplicação console em C#.

***using***

> Referencia *namespaces* dentro do .NET e dos projetos. Permite acessar funções de manipulações de programa.
>
> O *namespace* "System" é o *namespace* base do .NET que libera aceso a diversas funções de manipulação já fornecida pelo framework.

***namespace***

> Agrupamento de *classes* relacionadas. Por padrão, o Visual Studio (e Visual Studio Code) nomeia o namespace com o mesmo nome do projeto, mas pode ser alterado sem que ocorra problemas.
>
> Por questão de boa prática, é indicado colocar as *classes* em namespaces para uma melhor organização do projeto.

***class***

> Por convenção,a classe (*class*) já vem com o nome do arquivo (arquivo `Progran.cs`), e por questões de boas práticas e organização, é recomendado que a classe tenha o nome do arquivo (mas não é obrigatório).
>
> É a unidade básica da *programação orientada a objetos (POO)*, armazena o código e membros que o programador irá criar e utilizar em seu processo de criação.

***static void Main (string[] args)***

> Padrão do C# (CSharp) para identificar o *Entry Point* (ponto de entrada/ponto de partida) da aplicação.
>
> É aonde a execução começa. Tudo que estiver dentro deste método irá ser executado em primeiro lugar na sua aplicação.

---

### TIPOS BÁSICOS DE VALORES E DADOS

Dentro do C# e .NET, temos modos de se referir a valores de dados, e através destes valores, realizar cálculos e funções que necessitará de tais informações.

Na tabela a seguir, teremos os tipos de valores referentes a parte numérica utilizada tanto pelo C# quanto o .NET.

Primeiramente temos tipos com e sem sinal (negativos e positivos):

| C# Type |          .NET Type          | Signed | Size (bits) |      Range      | Default Value |
| :-----: | :-------------------------: | :----: | :---------: | :-------------: | :-----------: |
|  sbyte  |  System.Sbyte<br />(SByte)  |  Yes   |      1      |   -128 to 127   |       0       |
|  short  |  System.Int16<br />(Int16)  |  Yes   |      2      | -32786 to 32787 |       0       |
|   int   |  System.Int32<br />(Int32)  |  Yes   |      4      | -2³¹ to 2³¹ -1  |       0       |
|  long   |  System.Int64<br />(Int64)  |  Yes   |      8      | -2⁶³ to 2⁶³ -1  |      0L       |
|  byte   |   System.Byte<br />(Byte)   |   No   |      1      |    0 to 255     |       0       |
| ushort  | System.Uint16<br />(UInt16) |   No   |      2      |   0 to 65535    |       0       |
|  uint   | System.Uint32<br />(UInt32) |   No   |      4      |    0 to 2³²     |       0       |
|  ulong  | System.Uint64<br />(UInt64) |   No   |      8      |    0 to 2⁶³     |       0       |

Ponto flutuante (com casas após a vírgula):

| C# Type |           .NET Type           | Signed | Size (bits) |             Range              | Default Value |
| :-----: | :---------------------------: | :----: | :---------: | :----------------------------: | :-----------: |
|  float  |  System.Single<br />(Single)  |  Yes   |     32      |  ±1.5 × 10‾⁴⁵ to ±3.4 × 10³⁸   |     0.0F      |
| double  |  System.Double<br />(Double)  |  Yes   |     64      | ±5.0 × 10‾³²⁴ to ±1.7 × 10³⁰⁸  |     0.0D      |
| decimal | System.Decimal<br />(Decimal) |  Yes   |     128     | ±1.0 × 10‾²⁸ to ±7.9228 × 10²⁸ |     0.0M      |

*Para que seja possível visualizar o valor mínimo e máximo é necessário utilizar respectivamente as funções "**.MinValue**" e "**.MaxValue**".* *EXE.:* ```int.MinValue```; ```double.MaxValue```... 

Um caractere (tanto letra como número):

| C# Type |        .NET Type        | Size (bits) |         Range         | Default Value |
| :-----: | :---------------------: | :---------: | :-------------------: | :-----------: |
|  char   | System.Char<br />(Char) |     16      | Any Unicode charecter |     '\0'      |

Tipo Booleano (verdadeiro ou falso):

| C# Type |           .NET Type           | Size (bits) |    Values    |
| :-----: | :---------------------------: | :---------: | :----------: |
|  bool   | System.Boolean<br />(Boolean) |     16      | True / False |

Tipos de referência:

| C# Type |   .NET Type   | Description                                                  |
| :-----: | :-----------: | :----------------------------------------------------------- |
| string  | System.String | Cadeia de caracteres Unicode <br />**IMUTÁVEL** (tornando os programas mais seguros, simples e *thread safe*) |
| object  | System.Object | Um objeto genérico (toda classe em C# é subclasse de object) |

### SAÍDA DE DADOS

Para a impressão de dados padrão (tela do console) para o usuário, em C#, é utilizado os comandos ``Console.Write()`` e ``Console.WriteLine()``. O valor que será exibido para o usuário estará presente dentro dos parenteses.

O comando ``Console.WriteLine()`` adiciona, além do conteúdo a ser exibido, uma quebra de linha.

O comando ``Console.Write()`` não realiza esta quebra de linha.

### PLACEHOLDERS, CONCATENAÇÃO E INTERPOLAÇÃO

Estes modos de escrita de saída de dados tendem a ser utilizadas para que seja impresso na saída de uma forma mais eficiente e menos cansativa, pois ao invés de utilizar vários ``COnsole.Write`` ou ``Console.WriteLine``, com apenas um único comando de saída de dados será possível escrever tudo (ou quase tudo) em um dos comandos de saída.

```csharp	
using System;

namespace Exemplo
{
	class Progran
	{
    	static void Main(string[] args)
        {
            int age = 32; //tipo de valor inteiro
            double balance = 10.35784; //tipo de valor com ponto flutuante
            string name = "Maria"; //Tipo de valor de cadeia de caracteres
            
            //Placeholders(lugar de entrada)
            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2:F2} reais.", name, age, balance);
         	
            //Concatenação
            Console.WriteLine(name + " tem " + age + " anos de idade e saldo de " + balance.ToString("F2") + " reais");
            
            //Interpolação
            Console.WriteLine($"{name} tem {age} anos de idade e saldo de {balance:F2}");
        }
	}    
}
```

**Placeholders**

> Utilizando de chaves com uma numeração expecífica (como uma lista, que tem inicio em '0') é denominada a posição em que as devidas varíaveis irão entrar no contexto. Após definir todos os espaços que serão ocupados pelas variáveis, após o fechamento de aspas, separados por um vírgula, é a hora de inserir na ordem em que deseja ser apresentada as variáveis.

**Concatenação**

> Este modo utiliza a junção de várias partes, sendo agrupadas através do símbolo '+', que irá concatenar as variáveis junto ao texto escrito.

**Interpolação**

> A interpolação permite que, com o símbolo de '$' antes das aspas, a variável possa ser escrita dentro das chaves que anteriormente armazenaria somente a posição a qual a variável iria ser alocada.
