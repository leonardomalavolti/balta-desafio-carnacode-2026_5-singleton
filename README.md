![CR-5](https://github.com/user-attachments/assets/e212d619-61a8-4e74-8b15-283b374c9d3f)

# 🥁 CarnaCode 2026 - Desafio 05 - Singleton

Oi, eu sou o **Leonardo Malavolti Monteiro** 👋 e este é o espaço onde
compartilho minha jornada de aprendizado durante o desafio **CarnaCode
2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou
desenvolvendo durante o desafio. O objetivo é colocar a mão na massa,
testar ideias e registrar minha evolução no mundo da tecnologia.

------------------------------------------------------------------------

## 📌 Sobre este desafio

No desafio **Singleton** eu tive que resolver um problema real
implementando o **Design Pattern** em questão.

Neste processo eu aprendi:

-   ✅ Boas Práticas de Software
-   ✅ Código Limpo
-   ✅ SOLID
-   ✅ Design Patterns (Padrões de Projeto)

------------------------------------------------------------------------

## 🧩 Problema

Uma aplicação precisa carregar configurações de banco de dados, APIs e
cache **uma única vez** e compartilhar entre todos os componentes.

O código original permitia múltiplas instâncias do
`ConfigurationManager`, causando:

-   Inconsistência de dados\
-   Desperdício de memória\
-   Desperdício de processamento\
-   Múltiplos carregamentos desnecessários

------------------------------------------------------------------------

## 🎯 Objetivo

Aplicar o padrão **Singleton** para:

-   Garantir que apenas uma instância de `ConfigurationManager` exista
-   Centralizar o carregamento das configurações
-   Compartilhar o estado entre todos os serviços
-   Melhorar performance e consistência

------------------------------------------------------------------------

## 🏗️ Solução Arquitetural

A classe `ConfigurationManager` foi transformada em um Singleton
thread-safe utilizando `Lazy<T>`:

``` csharp
public sealed class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance =
        new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    public static ConfigurationManager Instance => _instance.Value;

    private ConfigurationManager()
    {
    }
}
```

Principais mudanças:

-   Construtor privado
-   Instância única controlada internamente
-   Inicialização tardia (Lazy Initialization)
-   Thread-safety garantida

Todos os serviços passaram a utilizar:

``` csharp
ConfigurationManager.Instance
```

------------------------------------------------------------------------

## 📂 Estrutura do Projeto

    Core
     └── ConfigurationManager

    Services
     ├── DatabaseService
     ├── ApiService
     ├── CacheService
     └── LoggingService

    Program

------------------------------------------------------------------------

## 💡 Benefícios Obtidos

-   ✔ Eliminação de múltiplas instâncias
-   ✔ Estado consistente em toda aplicação
-   ✔ Redução de consumo de memória
-   ✔ Melhor controle do ciclo de vida do objeto
-   ✔ Código mais previsível

------------------------------------------------------------------------

## 📚 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões
de projeto (Design Patterns) em cenários reais.

Durante os 23 desafios desta jornada, os participantes são submetidos ao
aprendizado e prática na identificação de códigos não escaláveis e na
solução de problemas utilizando padrões de mercado.

------------------------------------------------------------------------

## 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook
gratuito:

👉 https://lp.balta.io/ebook-fundamentos-design-patterns

------------------------------------------------------------------------

## 🚀 Próximos Passos

-   Implementar controle via Dependency Injection
-   Adicionar testes unitários para validar instância única
-   Explorar limitações e cuidados ao utilizar Singleton

------------------------------------------------------------------------

📌 Este projeto faz parte da minha evolução contínua como desenvolvedor
backend .NET.
