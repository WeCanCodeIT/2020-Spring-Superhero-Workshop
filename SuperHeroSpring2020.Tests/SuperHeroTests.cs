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
            Assert.Equal(false, mySuper.hasCape);
        }
    }
}
