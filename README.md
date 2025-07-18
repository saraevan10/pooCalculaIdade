# Calcula Idade 🎂

## Sobre o Projeto
O objetivo principal é construir um aplicativo simples que **calcula a idade de uma pessoa**. Mais do que um cálculo preciso, o foco está em reforçar o uso de **métodos públicos e privados** e a **construção de objetos e classes** em C#.

## Funcionalidades ✨
**Classe** `Pessoa`

A classe `Pessoa` representa uma pessoa e possui:

- **Propriedades (Características):**

    - `nome` (string): Armazena o nome da pessoa, convertido para maiúsculas. É uma propriedade **privada** (encapsulada).

    - `anoNascimento` (int): Armazena o ano de nascimento. Também é **privada** para encapsulamento.

- **Métodos (Ações):**

    - `ExibirDados()`: Um método **público** que mostra o nome, a idade calculada e o ano de nascimento da pessoa.

    - `CalcularIdade()`: Um método **privado** que calcula a idade. Ele obtém o ano atual do sistema e subtrai o ano de nascimento. Este método é chamado internamente por `ExibirDados()`.

**Programa Principal** (Program.cs)

O programa principal é responsável por:

1. Exibir uma mensagem de boas-vindas.

2. **Criar um novo objeto** `Pessoa`.

3. **Interagir com o usuário** para obter o nome e o ano de nascimento.

4. **Chamar o método** `ExibirDados()` do objeto `Pessoa` para exibir as informações coletadas e a idade calculada.

5. Manter o console aberto para visualização dos resultados.
