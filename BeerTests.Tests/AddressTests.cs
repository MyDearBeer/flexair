using BeerShop.Data;
using System;
using Xunit;

namespace BeerShop.Tests
{
    public class AddressTests
    {
        [Fact]
        public void GetFullAddress_UkraineAndKyivAndKhreshchatyk_ReturnEqual()
        {
            //Arrange
            var sut = new Address("Khreshchatyk", "Ukraine", "Kyiv");
            var expected = "Ukraine М.Kyiv Вул.Khreshchatyk";

            //Act
            var actual = sut.GetFullAddress();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetFullAddress_UkraineAndKyivAndKhreshchatyk_SetEqual()
        {
            //Arrange
            var sut = new Address();
            var address = "Ukraine|Kyiv|Khreshchatyk";

            //Act
            sut.SetFullAddress(address);

            //Assert
            Assert.Equal("Ukraine", sut.Country);
            Assert.Equal("Kyiv", sut.City);
            Assert.Equal("Khreshchatyk", sut.Street);
        }
        
        [Fact]
        public void SetFullAddress_CallExeption_ReturnExeptionWasThrown()
        {
            //Arrange
            var sut = new Address();
            var address = "UkraineKyiv|Khreshchatyk";

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => sut.SetFullAddress(address));
        }

        [Fact]
        public void SetFullAddress_CallNullExeption_ReturnExeptionWasThrown()
        {
            //Arrange
            var sut = new Address();
            string address = null;

            //Assert
            Assert.Throws<NullReferenceException>(() => sut.SetFullAddress(address));
        }
    }
}