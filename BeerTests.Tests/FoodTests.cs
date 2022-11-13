using BeerShop.Data;
using Xunit;

namespace BeerShop.Tests
{
    public class FoodTests
    {
        [Fact]
        public void Food_ObjectInitialization_ReturnEqual()
        {
            //Arrange
            Food food1 = new Food("Moiva", "Fish", 100, 500);
            Food food2 = new Food("Kambala", "Fish", 50, 300);

            //Act
            Food sut = new Food(food1);

            //Assert
            Assert.Equal(food1.DataToStr(), sut.DataToStr());
        }

        [Fact]
        public void Weight_ConditionOK_ReturnEqual()
        {
            //Arrange
            Food sut = new Food();
            int expected = 100;

            //Act
            sut.Weight = 100;

            //Assert
            Assert.Equal(expected, sut.Weight);
        }

        [Fact]
        public void Weight_CallExeption_ReturnExeptionWasThrown()
        {
            //Arrange
            Food sut = new Food();

            //Assert
            Assert.Throws<FoodWeightException>(() => sut.Weight = 1000);
        }

        [Theory]
        [InlineData("Снеки")]
        [InlineData("В'ялка")]
        [InlineData("Риба")]
        public void Type_ConditionOK_ReturnEqual(string value)
        {
            //Arrange
            Food sut = new Food();
            var expected = value;

            //Act
            sut.Type = value;

            //Assert
            Assert.Equal(expected, sut.Type);
        }

        [Fact]
        public void Type_CallExeption_ReturnExeptionWasThrown()
        {
            //Arrange
            Food sut = new Food();

            //Assert
            Assert.Throws<FoodTypeError>(() => sut.Type = "CallEx");
        }

        [Fact]
        public void SetAll_ValueAssignment_ReturnEqual()
        {
            //Arrange
            Food food1 = new Food("Moiva", "Fish", 100, 500);
            Food food2 = new Food();

            //Act
            food2.SetAll("Moiva", 100, 500, "Fish");

            //Assert
            Assert.Equal(food1.DataToStr(), food2.DataToStr());
        }

        [Fact]
        public void DataToString_ListFoods_ReturnEqual()
        {
            //Arrange
            var sut = new Food("Бик", "Снеки", 21, 500);
            var expected = "Назва товару : Бик\n\tЦіна : 21 грн\n\tТип : Снеки\n\tВага500 грам";

            //Act
            var actual = sut.DataToStr();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}