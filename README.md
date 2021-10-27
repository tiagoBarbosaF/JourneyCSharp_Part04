# Entendendo exceções

## Objetivos ao completar os estudos

- Conheça a pilha de chamadas
- Entenda o tratamento de exceções
- Crie suas próprias exceções
- Use o bloco try/catch/finally e using
- Entenda a interface IDisposable

## Ementas:

### Primeiros passos com exceções
- Pré-requisitos
- Conhecendo exceções
- Exceção de divisão por 0
- Lidando com erros
- Pilha de chamadas
- Blocos Try Catch
- Capturando exceções
- Propagando exceções
- Mãos na massa
- O que aprendi?
  - Como funciona a pilha de chamadas (CallStack) no .NET;
  - Propagar erros com retorno de métodos não é correto;
  - Podemos usar as exceções do .NET;
  - Para tratar exceções do .NET, basta usar os blocos try/catch;
  - As exceções são representadas por objetos e duas propriedades importantes são a `Message` e `StackTrace`.

### Tratamento de exceções
- Projeto da aula anterior
- Tratando várias exceções
- Palavra reservada throw
- Capturando exceções
- Relançando exceções
- Mãos na massa
- O que aprendi?
  - O bloco `try` pode acompanhar vários blocos `catch`;
  - A CLR visita os blocos `catch` em ordem, de cima para baixo. Por esta razão, os tipos de exceção mais específicos devem estar no começo;
  - A instrução `throw;`, dentro de um bloco `catch`, relança uma exceção.

### `ArgumentException`, `ParamName` e `nameof`
- Projeto da aula anterior
- Propriedades somente leitura
- Lançando nossa exceção de argumento
- ParamName no ArgumentException e operador nameof
- Propriedade Somente-Leitura
- Mãos na massa
- O que aprendi?
  - Campos somente leitura com o modificador readonly;
  - Propriedades somente leitura, com omissão do setter;
  - O operador `nameof()`;
  - A classe de exceção `ArgumentException`, seus construtores e propriedades;

### Criando exceções ricas
- Projeto da aula anterior
- Criando nossa própria exceção
- Tornando as exceções mais ricas
- Criando tipos de exceção
- Mãos na massa
- O que aprendi?
  - Convenções de nomeação de exceções;
  - Construtores comuns de exceções;
  - Como criar uma exceção mais rica.

### StackTrace e InnerException
- Projeto da aula anterior
- Quando o StackTrace é preenchido
- Usando inner exceptions
- throw; vs. throw ex;
- Mãos na massa
- O que aprendi?
  - As diferenças entre `throw;` e `throw ex;`;
  - Como a CLR preenche a propriedade `StackTrace`;
  - O padrão de inner exceptions;
  - O terceiro construtor que as exceções devem ter: (`string mensagem`, `Exception excecaoInterna`);

### Finally e using
- Projeto da aula anterior
- Bloco finally
- Liberando recursos
- Conclusão
- Projeto final do curso
- Açúcar sintático using
- Mãos na massa
- O que aprendi?
  - O bloco `finally`;
  - Não é obrigatório o bloco `catch` quando temos um finally;
  - Como é usado o bloco `using` e como ele funciona;
  - A interface `IDisposable`.