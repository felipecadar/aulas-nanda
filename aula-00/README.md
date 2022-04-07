# Geral

### Método Principal

O método Main é o ponto de entrada de um aplicativo C#. Pode haver apenas um ponto de entrada em um programa C#.
A partir do C# 9, você não precisa incluir explicitamente um Main método em um projeto de aplicativo de console. Em vez disso, você pode usar o recurso de **instruções de nível superior** (TLI) para minimizar o código que você precisa escrever.



<table>
  <tr>
    <td>Main</td> 
    <td>TLI</td>
  </tr>
  <tr>
    <td>

```C#
class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine('Hello Word');
    }
}
```

 </td> 
    <td>
    
```C#
Console.WriteLine('Hello Word');






```
</td>
  </tr>
</table>

# 1. Classes

C# é uma linguagem de programação orientada a objeto. Os quatro princípios básicos da programação orientada a objeto são:
- Abstração Modelando os atributos relevantes e as interações de entidades como classes para definir uma representação abstrata de um sistema.
- Encapsulamento Ocultando o estado interno e a funcionalidade de um objeto e permitindo apenas o acesso por meio de um conjunto público de funções.
- Herança Capacidade de criar novas abstrações com base em abstrações existentes.
- Polimorfismo Capacidade de implementar propriedades ou métodos herdados de maneiras diferentes em várias abstrações.


### 1.1 Declarando Classes

As classes são declaradas usando a palavra-chave class seguida por um identificador exclusivo. A palavra-chave `class` é precedida pelo nível de acesso, mas vamos falar sobre isso mais tarde.

```C#
//[access modifier] - [class] - [identifier]
public class ContaDoBanco
{
   // Fields, properties, methods and events go here...
}
```

### 1.2 Criando objetos

Uma classe define um tipo de objeto, mas não é um objeto em si. Um objeto é uma entidade concreta com base em uma classe e, às vezes, é conhecido como uma instância de uma classe. Os objetos podem ser criados usando a new palavra-chave seguida pelo nome da classe em que o objeto será baseado.

```C#
ContaDoBanco object1 = new ContaDoBanco();
```

Quando uma instância de uma classe é criada, uma referência ao objeto é passada de volta para o programador. No exemplo anterior, object1 é uma referência a um objeto que é baseado em Customer. Esta referência refere-se ao novo objeto, mas não contém os dados de objeto. Na verdade, você pode criar uma referência de objeto sem criar um objeto. A princípio isso não parece muito útil, mas pode ser usado para se referir a um objeto ja existente no problema.

```C#
// Criando referencência para um objeto
ContaDoBanco object1;
```

```C#
// Criando um objeto
ContaDoBanco object3 = new ContaDoBanco();
// Atribuindo o endereço de um objeto ja existem a uma referência que criamos.
ContaDoBanco object4 = object3;
```
### 1.3 Herança de classe

As classes dão suporte completo à herança, uma característica fundamental da programação orientada a objetos.

```C#
public class Gerente : Funcionário
{
    // campos, propriedades, metodos e eventos de Funcionario são herdados
    // Novos campos, propriedades, metodos e eventos de Gerente são declarados aqui
}
```

Quando uma classe declara uma classe base, ela herda todos os membros da classe base, exceto os construtores. Uma classe em C# só pode herdar diretamente de uma classe base. No entanto, como uma classe base pode herdar de outra classe, uma classe pode herdar indiretamente várias classes base.

```C#
example here
```

Uma classe pode ser declarada abstract. Uma classe abstrata contém métodos abstratos que têm uma definição de assinatura, mas não têm implementação. As classes abstratas não podem ser instanciadas. Elas só podem ser usadas por meio de classes derivadas que implementam os métodos abstratos.

```C#
example here
```

Por outro lado, uma classe lacrada não permite que outras classes sejam derivadas dela

### 1.4 Modificadores de acesso

Os modificadores de acesso são palavras-chave usadas para especificar a acessibilidade declarada de um membro ou de um tipo. Eles são:
- `public`
- `protected`
- `internal`
- `private`

Os seis seguintes níveis de acessibilidade podem ser especificados usando os modificadores de acesso:
- `public`: o acesso não é restrito.
- `protected`: o acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
- `internal`: o acesso é limitado ao assembly atual.
- `protected internal`: o acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.
- `private`: o acesso é limitado ao tipo recipiente.
- `private protected`: o acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual.

# [Exercício de Conta Bancária](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/classes)

O exercício consiste em contruir uma classe que possui algumas funções simples de uma conta bancária.

