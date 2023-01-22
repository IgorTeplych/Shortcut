namespace Shortcut.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SearchPathTest()
        {
            //https://prog-cpp.ru/deikstra/
            int m = int.MaxValue;
            int[][] vect = new int[6][];
            vect[0] = new int[] { 0, 7, 9, m, m, 14 };
            vect[1] = new int[] { 7, 0, 10, 15, m, m };
            vect[2] = new int[] { 9, 10, 0, 11, m, 2 };
            vect[3] = new int[] { m, 15, 11, 0, 6, m };
            vect[4] = new int[] { m, m, m, 6, 0, 9 };
            vect[5] = new int[] { 14, m, 2, m, 9, 0 };
            Dijkstra d = new Dijkstra();
            Edge[] edges = d.GetShortPath(vect, 0, 4);

            Assert.AreEqual(edges[0].V1, 0);
            Assert.AreEqual(edges[0].V2, 2);

            Assert.AreEqual(edges[1].V1, 2);
            Assert.AreEqual(edges[1].V2, 5);

            Assert.AreEqual(edges[2].V1, 5);
            Assert.AreEqual(edges[2].V2, 4);
        }
    }
}