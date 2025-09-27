#include <bits/stdc++.h>

#define pai pair<int, int>

using namespace std;
typedef long long ll;

vector<int> dijkstra(vector<vector<pair<int, int>>> adj, int src) {
  vector<bool> visited(adj.size(), false);
  vector<int> pred(adj.size(), -1);
  vector<int> dist(adj.size(), INT_MAX);
  priority_queue<pai, vector<pai>, greater<pai>> pq;

  pq.push({0, src});
  dist[src] = 0;

  while (!pq.empty()) {
    auto curr = pq.top();
    pq.pop();

    if (visited[curr.second])
      continue;

    visited[curr.second] = true;

    for (int i = 0; i < adj[curr.second].size(); i++) {
      auto v = adj[curr.second][i].second;
      auto d = adj[curr.second][i].first;
      if (dist[v] <= d + dist[curr.second])
        continue;

      dist[v] = d + dist[curr.second];
      pred[v] = curr.second;
      pq.push({dist[v], v});
    }
  }

  return dist;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  vector<vector<pair<int, int>>> adj(5);
  adj[0] = vector<pair<int, int>>{{3, 1}, {7, 3}, {8, 4}};
  adj[1] = vector<pair<int, int>>{{3, 0}, {1, 2}, {4, 3}};
  adj[2] = vector<pair<int, int>>{{1, 1}, {2, 3}};
  adj[3] = vector<pair<int, int>>{{7, 0}, {4, 1}, {2, 2}, {3, 4}};
  adj[4] = vector<pair<int, int>>{{8, 0}, {3, 3}};

  auto ans = dijkstra(adj, 0);

  cout << "-- DISTANCES --" << endl;
  for (auto i : ans) {
    cout << i << " ";
  }
  cout << endl;

  return 0;
}
