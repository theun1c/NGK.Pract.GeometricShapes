using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример дерева: список рёбер (ребро - пара вершин)
        // Допустим, у нас 5 вершин, рёбра такие: (1-2), (1-3), (3-4), (3-5)
        int[,] edges = new int[,]
        {
            {1, 2},
            {1, 3},
            {3, 4},
            {3, 5}
        };

        int n = 5; // Количество вершин

        List<int> pruferCode = GetPruferCode(edges, n);

        Console.WriteLine("Код Прюфера:");
        foreach (int num in pruferCode)
        {
            Console.Write(num + " ");
        }
    }

    static List<int> GetPruferCode(int[,] edges, int n)
    {
        // Создаем список смежности (соседей) для каждой вершины
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        for (int i = 1; i <= n; i++)
            adj[i] = new List<int>();

        // Заполняем граф
        for (int i = 0; i < edges.GetLength(0); i++)
        {
            int u = edges[i, 0];
            int v = edges[i, 1];

            adj[u].Add(v);
            adj[v].Add(u);
        }

        List<int> prufer = new List<int>();

        for (int i = 0; i < n - 2; i++) // Код Прюфера длины n-2
        {
            // Находим вершину с наименьшим номером и степенью 1 (лист)
            int leaf = -1;

            for (int j = 1; j <= n; j++)
            {
                if (adj[j].Count == 1)
                {
                    leaf = j;
                    break;
                }
            }

            int neighbor = adj[leaf][0];
            prufer.Add(neighbor);

            // Удаляем ребро между листом и соседом
            adj[neighbor].Remove(leaf);
            adj[leaf].Clear(); // удаляем лист
        }

        return prufer;
    }
}
