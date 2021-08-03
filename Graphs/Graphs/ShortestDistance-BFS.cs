using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class ShortestDistance_BFS
    {
        // undirected graph
        Graph g;
        LinkedList<int>[] adj;
        public ShortestDistance_BFS(Graph graph)
        {
            this.g = graph;
            this.adj = g.getAdj;
        }
        public void shortestPath(int v,int src)
        {
            int[] dist = new int[v];
            for(int i = 0; i < v; i++)
            {
                dist[i] = int.MaxValue;
            }

            LinkedList<int> queue = new LinkedList<int>();
            dist[src] = 0;
            queue.AddLast(src);

            while(queue.Count > 0)
            {
                int node = queue.First.Value;
                queue.RemoveFirst();

                foreach (var item in adj[node])
                {
                    if(dist[item]+1 < dist[node])
                    {
                        dist[item] = dist[item] + 1;
                        queue.AddLast(item);
                    }
                }
            }

            for(int i = 0; i < v; i++)
            {
                Console.Write($"{dist[i]}, ");
            }
        }
    }
}
