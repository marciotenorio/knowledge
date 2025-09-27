namespace CsharpStudy.Graphs;

public class Graph
{
    public static List<int> Bfs(List<List<int>> adj, int src)
    {
        var visited = new bool[adj.Count];
        var dist = new int[adj.Count];
        var queue = new Queue<int>();
    
        queue.Enqueue(src);
        dist[src] = 0;
        visited[src] = true;

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();

            foreach (var i in adj[curr])
            {
                if (visited[i]) continue;
            
                dist[i] = dist[curr] + 1;
                visited[i] = true;
                queue.Enqueue(i);
            }
        }

        return dist.ToList();
    }
    
    public static List<List<int>> GetAdjacentGraph() =>
    [
        new() { 1, 4 },
        new() { 0, 2 },
        new() { 1, 4 },
        new() { 4 },
        new() { 0, 2, 3 }
    ];
}