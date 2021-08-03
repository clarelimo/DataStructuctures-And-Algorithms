using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);

            g.DfsIterative(2);
            g.DFSRecursive(2);

            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            ShortestPath_Dijkstra.dijkstra(graph, 0);

            Graph g1 = new Graph(5);
            g1.AddEdge(1, 0);
            g1.AddEdge(0, 2);
            g1.AddEdge(2, 1);
            g1.AddEdge(0, 3);
            g1.AddEdge(3, 4);

            DetectCycle detectCycle = new DetectCycle(g1);

            if (detectCycle.IsCycle(5))
            {
                Console.WriteLine("The graph contains a cycle");
            }
            else
            {
                Console.WriteLine("The graph doesnt contain a cycle");
            }

            Graph g3 = new Graph(8);
            g3.AddEdge(0, 1);
            g3.AddEdge(0, 3);
            g3.AddEdge(1, 2);
            g3.AddEdge(3, 4);
            g3.AddEdge(3, 7);
            g3.AddEdge(4, 5);
            g3.AddEdge(5, 6);
            g3.AddEdge(4, 7);
            g3.AddEdge(5, 6);
            g3.AddEdge(6, 7);

            ShortestDistance_BFS bfs = new ShortestDistance_BFS(g3);
            bfs.shortestPath(8,0);
        }
    }
}
