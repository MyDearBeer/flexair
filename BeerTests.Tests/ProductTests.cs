using BeerShop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BeerTests.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Beer_ObjectInitialization_ReturnEqual()
        {
            //Arrange
            Beer beer1 = new Beer("Пиво", 20, 5.2, "Бренд");

            //Act
            Beer sut = new Beer(beer1);

            //Assert
            Assert.Equal(beer1.DataToStr(), sut.DataToStr());
        }

        [Fact]
        public void Beer_TruePrice_ReturnEqual()
        {
            //Arrange
            Beer sut = new Beer();
            int expected = 10;

            //Act
            sut.price = 10;

            //Assert
            Assert.Equal(expected, sut.price);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(10001)]

        public void Price_CallExeption_ReturnExeptionWasThrown(int price)
        {
            //Arrange
            Beer sut = new Beer();


            //Assert
            Assert.Throws<PriceException>(() => sut.price = price);
        }

        [Fact]
        public void Beer_TrueAlcoholStrenght_ReturnEqual()
        {
            //Arrange
            Beer sut = new Beer();
            double expected = 4.2;

            //Act
            sut.alcoholStrenght = 4.2;

            //Assert
            Assert.Equal(expected, sut.alcoholStrenght);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(-1)]


        public void AlcoholStrenght_CallExeption_ReturnExeptionWasThrown(int alcoholStrenght)
        {
            //Arrange
            Beer sut = new Beer();


            //Assert
            Assert.Throws<BeerStrenghtException>(() => sut.alcoholStrenght = alcoholStrenght);
        }

        [Fact]
        public void SetAll_ValueAssignment_ReturnEqual()
        {
            //Arrange
            Beer beer1 = new Beer("Пиво", 20, 5.2, "Бренд");
            Beer beer2 = new Beer();

            //Act
            beer2.SetAll("Пиво", 20, 5.2, "Бренд");

            //Assert
            Assert.Equal(beer1.name, beer2.name);
            Assert.Equal(beer1.price, beer2.price);
            Assert.Equal(beer1.alcoholStrenght, beer2.alcoholStrenght);
            Assert.Equal(beer1.brand, beer2.brand);
        }

    }
}
