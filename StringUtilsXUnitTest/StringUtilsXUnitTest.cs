using Xunit;
using SmartSystems;

namespace StringUtilsXUnitTest
{
    public class StringUtilsXUnitTest 
    {
        [Theory]
        [InlineData("Able was I ere I saw elbA")]
        [InlineData("kayak")]
        public void IsMirrorSequencetValidValue(string str_Original)
        {

            StringUtils su = new StringUtils();

            //---Assert.Equal(employee.Name, _e.Name.ToString());
            Assert.True(su.IsMirrorSequence(str_Original));
        }

        [Theory]
        [InlineData("Able was I ere I saw elba")]
        [InlineData("kayakaa")]
        public void IsMirrorSequencetNotValidValue(string str_Original)
        {

            StringUtils su = new StringUtils();

            //---Assert.Equal(employee.Name, _e.Name.ToString());
            Assert.False(su.IsMirrorSequence(str_Original));
        }
    }
}
