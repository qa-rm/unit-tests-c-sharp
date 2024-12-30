using PrjConsole;

namespace PrjXUnitTests
{
    public class CalculadoraTests
    {
        Calculadora calc = new Calculadora();

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int val1, int val2, int res)
        {
            int resultado = calc.somar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData (1, 2, -1)]
        [InlineData (4, 5, -1)]
        public void TestSubtrair(int val1, int val2, int res)
        {            
            int resultado = calc.subtrair(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int res)
        {           
            int resultado = calc.multiplicar(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData (1, 2, 0)]
        [InlineData (4, 5, 0)]
        public void TestDividir(int val1, int val2, int res)
        {           
            int resultado = calc.dividir(val1, val2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestHistorico()
        {
            calc.somar(1, 2);
            calc.somar(3, 4);
            calc.somar(5, 6);
            calc.somar(7, 8);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
