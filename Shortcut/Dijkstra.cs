using BasicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcut
{
    public class Dijkstra
    {
        int infinity = int.MaxValue;
        int[] price;
        int[][] G;
        SingleArray<int> path;
        int startVertex;
        public Edge[] GetShortPath(int[][] g, int startVertex, int endVertex)
        {
            G = g;
            this.startVertex = startVertex;
            path = new SingleArray<int>();
            price = new int[g.Length];
            for (int i = 0; i < price.Length; i++)
                price[i] = int.MaxValue;

            price[startVertex] = 0;

            //Resolvening the price of all vertexes
            for (int i = startVertex; i < g.Length; i++)
            {
                int[] h = g[i];
                for (int j = 0; j < h.Length; j++)
                {
                    if (h[j] != infinity)
                    {
                        if (price[i] + h[j] < price[j])
                        {
                            price[j] = price[i] + h[j];
                        }
                    }
                }
            }
            SearchPath(endVertex);

            SingleArray<Edge> edges = new SingleArray<Edge>();
            while (path.Size > 1)
            {
                Edge edge = new Edge(path.Get(path.Size - 1), path.Get(path.Size - 2));
                edges.Add(edge, edges.Size);
                path.Remove(path.Size - 1);
            }
            return edges.Array;
        }

        void SearchPath(int vertex)
        {
            path.Add(vertex, path.Size);

            if (vertex == startVertex)
                return;

            int[] h = G[vertex];
            for (int i = 0; i < h.Length; i++)
            {
                int prc = price[vertex];
                if (h[i] != 0 && h[i] != infinity)
                {
                    if (prc - h[i] == price[i])
                        SearchPath(i);
                }
            }
        }

    }
}
