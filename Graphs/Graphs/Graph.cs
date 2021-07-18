using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        private int vertices;
        private LinkedList<int>[] adj;

        public Graph(int v)
        {
            vertices = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int c, int v)
        {
            adj[c].AddLast(v);
        }

        public void DfsIterative(int v)
        {
            bool[] visited = new bool[vertices];
            var st = new Stack<int>();

            st.Push(v);

            while(st.Count > 0)
            {
                v = st.Peek();
                st.Pop();
                if (visited[v] == false)
                {
                    visited[v] = true;
                    Console.Write(v + "->");
                }
               
                foreach (var item in adj[v])
                {
                    if (!visited[item])
                    {
                        st.Push(item);
                    }
                }
            }
        }
        public void DfsUtil(int v, bool[] visited)
        {
            //mark te current node as visited and print it
            visited[v] = true;
            Console.Write(v+"->");

            //recur for all the vertices adj to curr vertex
            //if they havent been visited
            foreach (var item in adj[v])
            {
                if (!visited[item])
                {
                    DfsUtil(item, visited);
                }
            }
        }
        public void DFSRecursive(int v)
        {
            bool[] visited = new bool[vertices];

            DfsUtil(v, visited);
        }

        public void BFS(int v)
        {
            //mark all vertices as not visited
            bool[] visited = new bool[vertices];
            //create a queue for bfs
            Queue<int> queue = new Queue<int>();
            //mark the current node as visited and add it to the queue
            visited[v] = true;
            queue.Enqueue(v);

            while(queue.Count > 0)
            {
                // dequeue a vertex from the queue and print it
                v = queue.Dequeue();
                Console.WriteLine(v+"->");
                
                //get all adjacent vertices(neighbors). If a vertex hasn't been visited,
                // mark it as visited and enqueue it.
                foreach (var item in adj[v])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.Enqueue(item);
                    }
                }
            }
        }
    }
}
