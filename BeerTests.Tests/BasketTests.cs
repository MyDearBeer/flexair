using BeerShop.Data;
using System;
using Xunit;

namespace BeerShop.Tests
{
    public class BasketTests
    {
        [Fact]
        public void GetProductFromDatabase_GetProducts_ReturnEqual()
        {
            //Arrange
            var sut = new Basket();
            Product pr1 = new Product("Pivo1", 25);
            Product pr2 = new Product("Pivo2", 10);
            Product pr3 = new Product("Pivo3", 15);
            sut.PushProduct(pr1);
            sut.PushProduct(pr2);
            sut.PushProduct(pr3);
            var expected = pr1;

            //Act
            var actual = sut.GetProductFromDatabase(0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetProductFromDatabase_GetProducts_ReturnEx()
        {
            //Arrange
            var sut = new Basket();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetProductFromDatabase(-1));
        }

        [Fact]
        public void DeleteProduct_DeleteProduct_ReturnEqual()
        {
            //Arrange
            var sut = new Basket();
            Product pr1 = new Product("Pivo1", 25);
            Product pr2 = new Product("Pivo2", 10);
            Product pr3 = new Product("Pivo3", 15);
            sut.PushProduct(pr1);
            sut.PushProduct(pr2);
            sut.PushProduct(pr3);

            //Act
            sut.DeleteProduct(1);

            //Assert
            Assert.DoesNotContain(pr2, sut.products);
        }

        [Fact]
        public void DeleteProduct_DeleteProduct_ReturnEx()
        {
            //Arrange
            var sut = new Basket();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.DeleteProduct(-1));
        }

        [Fact]
        public void GetCount_CountProducts_Return4()
        {
            //Arrange
            var sut = new Basket();
            Product pr1 = new Product("Pivo1", 25);
            Product pr2 = new Product("Pivo2", 10);
            Product pr3 = new Product("Pivo3", 15);
            Product pr4 = new Product("Pivo4", 20);
            sut.PushProduct(pr1);
            sut.PushProduct(pr2);
            sut.PushProduct(pr3);
            sut.PushProduct(pr4);
            var expected = 4;

            //Act
            var actual = sut.GetCount();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTotalCoast_25Plus10Plus15_Return50()
        {
            //Arrange
            var sut = new Basket();
            Product pr1 = new Product("Pivo1", 25);
            Product pr2 = new Product("Pivo2", 10);
            Product pr3 = new Product("Pivo3", 15);
            sut.PushProduct(pr1);
            sut.PushProduct(pr2);
            sut.PushProduct(pr3);
            var expected = 50;

            //Act
            var actual = sut.GetTotalCoast();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DataToString_ListProducts_ReturnEqual()
        {
            //Arrange
            var sut = new Basket();
            Product pr1 = new Product("Porige", 2);
            var expected = "1. Назва товару : Porige\n\tЦіна : 2 грн\n";
            sut.PushProduct(pr1);

            //Act
            var actual = sut.DataToString();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}