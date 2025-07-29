#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

vector<int> dijkstra(int src, vector<vector<pair<int, int>>> adj) {
  vector<bool> visited(adj.size(), false);
  vector<int> predecessor(adj.size(), -1);
  // {distance/weight, vertex number}
  priority_queue<pair<int, int>, vector<pair<int, int>>,
                 greater<pair<int, int>>>
      pq;
  vector<int> dist(adj.size(), INT_MAX);
  dist[src] = 0;

  pq.push(make_pair(dist[src], src));
  cout << "dijk";
  while (!pq.empty()) {
    auto curr = pq.top();
    pq.pop();

    if (visited[curr.second])
      continue;

    visited[curr.second] = true;
    for (auto i : adj[curr.second]) {
      auto vertex = i.second;
      auto edge_cost = i.first;

      if (dist[vertex] > (dist[curr.second] + edge_cost)) {
        dist[vertex] = dist[curr.second] + edge_cost;
        predecessor[vertex] = curr.second;
        pq.push(make_pair(dist[vertex], vertex));
      }
    }
  }

  return dist;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int mn;
  cin >> mn;

  int n, m;
  for (int i = 0; i < mn; i++) {
    cin >> n;
    cin >> m;

    vector<vector<pair<int, int>>> maze(n, vector<pair<int, int>>(m, {0, 0}));
    for (int j = 0; j < n; j++) {
      for (int k = 0; k < m; k++) {
        int in;
        cin >> in;
        maze[j][k] = {in, k};
      }
    }

    for (auto f1 : maze) {
      for (auto f2 : f1) {
        cout << f2.second << " ";
      }
      cout << endl;
    }

    // vector<int> ans = dijkstra(0, maze);
    // cout << ans[n] << endl;
  }

  return 0;
}
