using System;
using Tests;
using Xunit;

namespace Testes.test
{
    public class UnitTest1
    {

        // Verifica se a soma funciona.
        [Fact]
        public void Soma_DeveCalcularComSucesso()
        {
            // Arrange
            int n1 = 3;
            int n2 = 2;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Soma(n1, n2);

            // Assert
            Assert.True(result == 5);
        }

        // Verifica se a subtra��o funciona.
        [Fact]
        public void Subtracao_DeveCalcularComSucesso()
        {
            // Arrange
            int n1 = 5;
            int n2 = 2;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Subtracao(n1, n2);

            // Assert
            Assert.True(result == 3);
        }
        
        // Verifica se a multiplica��o funciona.
        [Fact]
        public void Multiplicacao_DeveCalcularComSucesso()
        {
            // Arrange
            int n1 = 2;
            int n2 = 10;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Multiplicacao(n1, n2);

            // Assert
            Assert.True(result == 20);
        }

        // Verifica se a divis�o funciona.
        [Fact]
        public void Divisao_DeveCalcularComSucesso()
        {
            // Arrange
            double n1 = 10;
            double n2 = 5;
            Calculos sut = new Calculos();

            // Act
            double result = sut.Divisao(n1, n2);

            // Assert
            Assert.True(result == 2);
        }


        // Verifica se o resultado � inteiro
        // (s� pode ser inteiro).
        [Fact]
        public void SomaResultadoInteiro()
        {
            // Arrange
            int n1 = 2;
            int n2 = 3;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Soma(n1, n2);

            // Assert
            Assert.IsType<int>(result);
        }

        // Verifica se o resultado � inteiro
        // (s� pode ser inteiro).
        [Fact]
        public void SubtracaoResultadoInteiro()
        {
            // Arrange
            int n1 = 2;
            int n2 = 3;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Subtracao(n1, n2);

            // Assert
            Assert.IsType<int>(result);
        }

        // Verifica se o segundo numero � inteiro
        // (n�o pode ter resultado fracionado).
        [Fact]
        public void MultiplicacaoPorNumeroInteiro()
        {
            // Arrange
            int n1 = 2;
            int n2 = 3;
            Calculos sut = new Calculos();

            // Act
            int result = sut.Multiplicacao(n1, n2);

            // Assert
            Assert.IsType<int>(result);
        }

        // Verifica se h� divis�o por zero.
        [Fact]
        public void Divisao_VerificaExcecaoCasoDivisaoPorZero()
        {
            // Arrange
            double n1 = 6;
            double n2 = 0;
            Calculos sut = new Calculos();

            // Act
            double result = sut.Divisao(n1, n2);

            // Assert
            Assert.Throws<DivideByZeroException>(() => sut.Divisao(n1, n2));
        }

    }
}
