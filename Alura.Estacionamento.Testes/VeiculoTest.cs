using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTest
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange          
            var veiculo = new Veiculo();

            //act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            //Arrange   
            var veiculo = new Veiculo();

            //act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaTipoVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            //assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
        }
    }    
}
