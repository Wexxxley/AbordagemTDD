# TDD(Test-Drive Development) 
 Test-Driven Development (Desenvolvimento Orientado por Testes), é uma abordagem de desenvolvimento de software onde os testes são escritos antes do código funcional. 

## Passo a passo
1. Escrever testes que falham: Você começa escrevendo um teste automatizado que define uma melhoria ou nova função que o código deve executar. Como o código funcional ainda não foi escrito, o teste deve falhar.
2. Escrever o Código Mínimo para Passar o Teste: Depois que o teste é escrito, você escreve a quantidade mínima de código necessário para fazer o teste passar.
3. Refatorar o Código: Com o teste passando, você refatora o código para melhorar sua legibilidade e eficiência, sem alterar seu comportamento externo. Os testes garantem que a funcionalidade se mantenha intacta durante a refatoração.

## Importância das regras de negócio
Antes de começar a usar TDD, é crucial ter as regras de negócio bem definidas pois:
1. Com regras de negócio bem definidas, os desenvolvedores sabem o que precisa ser alcançado. Isso ajuda a escrever testes que realmente refletem os requisitos.
2. Testes baseados em regras de negócio claras são mais precisos e eficazes, cobrindo cenários importantes.
3. Se as regras de negócio não são claras desde o início, há um alto risco de escrever testes e código que não atendem às necessidades reais do negócio, levando a retrabalho e desperdício de tempo.
