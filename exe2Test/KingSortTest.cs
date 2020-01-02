using exe2;
using System;
using Xunit;

namespace exe2Test
{
    public class KingSortTest
    {
        [Fact]
        public void ordinal10()
        {
            KingSort k = new KingSort();
            int c = k.SimplerConverter("X");
            Assert.Equal(10,c);
        }
        [Fact]
        public void ordinal9()
        {
            KingSort k = new KingSort();
            int c = k.SimplerConverter("IX");
            Assert.Equal(9, c);
        }
        [Fact]
        public void test0()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "Louis IX", "Louis VIII" };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "Louis VIII" , "Louis IX"}, kings);
        }
        [Fact]
        public void test1()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "Louis IX", "Philippe II"  };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "Louis IX", "Philippe II" }, kings);
        }
        [Fact]
        public void test2()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "Richard III", "Richard I", "Richard II" };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "Richard I", "Richard II", "Richard III" }, kings);
        }
        [Fact]
        public void test3()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "John X", "John I", "John L", "John V" };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "John I", "John V", "John X", "John L" }, kings);
        }
        [Fact]
        public void test4()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "Philippe VI", "Jean II", "Charles V", "Charles VI", "Charles VII", "Louis XI" };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "Charles V", "Charles VI", "Charles VII", "Jean II", "Louis XI", "Philippe VI" }, kings);
        }
        [Fact]
        public void test5()
        {
            KingSort ks = new KingSort();
            string[] k = new string[] { "Philippe II", "Philip II" };//pass
            string[] kings = ks.GetSortedList(k);
            Assert.Equal(new string[] { "Philip II", "Philippe II" }, kings);
        }
    }
}
