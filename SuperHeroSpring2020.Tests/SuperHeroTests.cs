using System;
using Xunit;

namespace SuperHeroSpring2020.Tests
{
    public class SuperHeroTests
    {
        [Fact]
        public void New_SuperHero_hasCape_is_false()
        {
            // Arrange
            // type objectName = new classConstructor();
            SuperHero mySuper = new SuperHero();

            // Act

            // Assert 
            Assert.False(mySuper.HasCape);
        }

        [Fact]
        public void IncreaseSpeed_Increases_SuperHero_Speed_By_10()
        {
            // Arrange
            SuperHero mySuper = new SuperHero();
            mySuper.Speed = 100;  // initial test value

            // Act
            mySuper.IncreaseSpeed(10);

            // Assert
            Assert.Equal(110, mySuper.Speed);
        }
    }
}
