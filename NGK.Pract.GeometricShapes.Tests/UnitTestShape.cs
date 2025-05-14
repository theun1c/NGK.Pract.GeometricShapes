using NGK.Pract.GeometricShapes.Model;

namespace NGK.Pract.GeometricShapes.Tests
{
    public class UnitTestShape
    {
        /// <summary>
        /// �������� ��������� �����
        /// </summary>
        [Fact]
        public void AddRadius_ShouldReturnCorrectPerimetr()
        {
            // arrange
            var citcle = new Circle();

            // act
            citcle.Radius = 12;
            double perimetr = citcle.Perimetr();

            // assert
            Assert.Equal(12 * 2 * Math.PI, perimetr);
        }

        /// <summary>
        /// �������� ������� �����
        /// </summary>
        [Fact]
        public void AddRadius_ShouldReturnCorrectPloshad()
        {
            // arrange
            var citcle = new Circle();
            
            // act
            citcle.Radius = 12;
            double ploshad = citcle.Ploshad();

            // assert
            Assert.Equal(12 * 12 * Math.PI, ploshad);
        }
    }
}