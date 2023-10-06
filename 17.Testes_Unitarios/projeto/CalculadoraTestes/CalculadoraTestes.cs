using Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar10com20ERetornar30()
    {
        //Arrange
        int num1 = 10;
        int num2 = 20;

        //Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(30, resultado);
    }

    public void DeveVerificarSeEhParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;
        // Act
        bool resultado = _calc.EhPar(numero);
        // Assert
        Assert.True(resultado);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros,num => Assert.True(_calc.EhPar(num)));

       
    }
}