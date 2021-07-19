using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public static class ShortestPath_Dijkstra
    {
        public static void dijkstra(int[,] graph, int src)
        {
            int v = graph.GetLength(0);
            int[] distance = new int[v];
            bool[] visited = new bool[v];

            //initialize all distance val to infinity
            for(int i = 0; i < v; i++)
            {
                distance[i] = int.MaxValue;
            }
            //update the source distance to 0
            distance[src] = 0;

            for(int i = 0; i < v - 1; i++)
            {
                //find vertex with the shortest distance
                int minVertex = FindMinVertex(distance, visited,v);
                visited[minVertex] = true;
                for(int j = 0; j < v; j++)
                {
                    if(!visited[j] && graph[minVertex,j] !=0 && distance[minVertex] != int.MaxValue && distance[minVertex] + graph[minVertex,j] < distance[j])
                    {
                        distance[j] = distance[minVertex] + graph[minVertex, j];
                    }
                }
            }

            PrintSol(distance, v);
        }

        public static int FindMinVertex(int[] distance,bool[] visited,int vertices)
        {
            int min = int.MaxValue, minIndex = -1;
            for(int i = 0; i < vertices; i++)
            {
                if (!visited[i] && distance[i] <= min)
                {
                    min = distance[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static void PrintSol(int[] dist,int vertices)
        {
            Console.Write("Vertex \t\t Distance "
                 + "from Source\n");
            for (int i = 0; i < vertices; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
            
        }
    }
}
