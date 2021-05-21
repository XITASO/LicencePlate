using Shouldly;
using Xunit;

namespace LicensePlate.Test
{
    public class LicensePlateTest
    {
        [Theory]
        [InlineData("A-XI100")]
        public void CreateLicensePlate_NonEmptyText_LicensePlateCreated(string text)
        {
            // Act
            var licensePlate = new LicensePlate(text);
            
            // Assert
            licensePlate.Text.ShouldBe(text);
        }
    }
}