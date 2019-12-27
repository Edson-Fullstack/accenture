using System;
using Xunit;

namespace exe1Text
{
    public class ProgramTest
    {
        [Fact]
        public void arara()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("arara");
            Assert.Equal(0, c);
        }
        [Fact]
        public void mussum()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("mussum");
            Assert.Equal(0, c);
        }
        [Fact]
        public void maratona()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("maratona");
            Assert.Equal(7, c);
        }
        [Fact]
        public void anili()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("anili");
            Assert.Equal(2, c);
        }
        [Fact]
        public void abcdef()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("abcdef");
            Assert.Equal(5, c);
        }
        [Fact]
        public void arar()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("arar");
            Assert.Equal(1, c);
        }
        [Fact]
        public void aaaaa()
        {
            Program pr = new Program();
            int c = pr.PalindromoCount("aaaaa");
            Assert.Equal(0, c);
        }
    }
}
