using exe2;
using System;
using Xunit;

namespace exe2Test
{
    public class ProgramTest
    {
        [Fact]
        public void ordinal10()
        {
            Program pr = new Program();
            int c = pr.SimplerConverter("X");
            Assert.Equal(10,c);
        }
    }
}
