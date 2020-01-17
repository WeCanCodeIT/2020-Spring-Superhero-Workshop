using System;
using Xunit;

namespace SuperHeroSpring2020.Tests
{
    public class SuperHeroTests
    {
        [Fact]
        public void New_Superhero_Has_No_Cape()
        {
            // Arrange
            SuperHero superHero = new SuperHero();

            // Assert


            // Act
            Assert.Equal(false, superHero.hasCape);
        }

        [Fact]
        public void New_Superhero_Has_StrengthLevel_10()
        {

        }

        [Fact]
        public void New_SuperHero_Cannot_Fly()
        {

        }
    }
}
