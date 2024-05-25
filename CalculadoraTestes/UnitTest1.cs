namespace CalculadoraTestes;
using Calculadora;

public class UnitTest1
{
    Calculadora _calc = new Calculadora();

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (1, 10, 11)]
    [InlineData (2000, 999, 2999)]
    public void TesteSomar(int a, int b, int resultExpected)
    {
        var result = _calc.Somar(a, b);
        Assert.Equal(resultExpected, result);
    }

    [Theory]
    [InlineData (1, 2, -1)]
    [InlineData (1, 10, -9)]
    [InlineData (2000, 999, 1001)]
    public void TesteSubtrair(int a, int b, int resultExpected)
    {
        var result = _calc.Subtrair(a, b);
        Assert.Equal(resultExpected, result);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (2, 10, 20)]
    [InlineData (2000, 3, 6000)]
    public void TesteMultiplicar(int a, int b, int resultExpected)
    {
        var result = _calc.Multiplicar(a, b);
        Assert.Equal(resultExpected, result);
    }

    [Theory]
    [InlineData (5, 5, 1)]
    [InlineData (10, 2, 5)]
    [InlineData (2000, 1000, 2)]
    public void TesteDividir(int a, int b, int resultExpected)
    {
        var result = _calc.Dividir(a, b);
        Assert.Equal(resultExpected, result);
    }

    [Fact]
    public void TestarDividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 2);
        _calc.Somar(1, 3);
        _calc.Somar(1, 4);
        var lista = _calc.ObterHistorico();
        Assert.NotEmpty(lista);

        Assert.Equal(3, lista.Count);
    }
}