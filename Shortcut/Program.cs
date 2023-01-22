

using Shortcut;

static class Programm
{
    public static void Main()
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
        var vr = d.GetShortPath(vect, 0, 4);
    }
}
