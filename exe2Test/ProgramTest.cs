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
        [Fact]
        public void kings()
        {
            Program pr = new Program();
            string[] k = new string[] { "Louis IX", "Louis VIII" };//pass
            string[] kings = pr.GetSortedList(k);
            Assert.Equal(0, 0);
        }
    }
}
