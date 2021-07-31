using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class DetectCycle
    {
        Graph graph;
        LinkedList<int>[] adj;
        public DetectCycle(Graph graph)
        {
            this.graph = graph;
            this.adj = graph.getAdj;
        }

        public bool IsCycle(int v)
        {
            bool[] visited = new bool[v];
            //mark all vertices as not visited

            for(int i = 0;i< v; i++)
            {
                visited[i] = false;
            }

            //call the check for a cycle fuction recursively to detect cycle in the tree
            for(int u = 0; u < v; u++)
            {
                if (!visited[u])
                {
                    if (CheckForCycle(u, visited, -1)){
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckForCycle(int v, bool[] visited, int parent)
        {
            visited[v] = true;

            //recur for all vertices adjacent to the vertex
            foreach (var item in adj[v])
            {
                if (!visited[item])
                {
                    if(CheckForCycle(item, visited, v))
                    {
                        return true;
                    }
                }else if(item != parent)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
