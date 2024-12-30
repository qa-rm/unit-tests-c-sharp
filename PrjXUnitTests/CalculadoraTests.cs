using System;
using System.Linq;
using System.Threading.Tasks;
using PrjConsole;
using Xunit;

namespace PrjXUnitTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Test1()
        {
            Calculadora calc = new Calculadora();
            
            int resultado = calc.somar(1, 2);

            Assert.Equal(3, resultado);
        }
    }
}
