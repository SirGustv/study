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

A estrutura base de uma aplicação console do C#.

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