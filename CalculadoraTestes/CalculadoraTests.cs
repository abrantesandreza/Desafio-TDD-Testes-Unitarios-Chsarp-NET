using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.Somar(num1, num2);

        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10Com10ERetornar0()
    {
        int num1 = 10;
        int num2 = 10;

        int resultado = _calc.Subtrair(num1, num2);

        Assert.Equal(0, resultado);
    }

    [Fact]
    public void DeveMultiplicar5Com5ERetornar25()
    {
        int num1 = 5;
        int num2 = 5;

        int resultado = _calc.Multiplicar(num1, num2);

        Assert.Equal(25, resultado);
    }

    [Fact]
    public void DeveDividir15Por3ERetornar5()
    {
        int num1 = 15;
        int num2 = 3;

        int resultado = _calc.Dividir(num1, num2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        int numero = 4;

        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(12)]    
    public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int numero)
    {
        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })] 
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarRefatorado(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}