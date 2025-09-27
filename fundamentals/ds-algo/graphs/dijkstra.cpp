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

  return predecessor;
}

void get_path(vector<int> pred, int end) {
  if (pred.empty())
    return;

  stack<int> s;
  s.push(end);
  while (pred[end] != -1) {
    end = pred[end];
    s.push(end);
  }

  while (!s.empty()) {
    cout << s.top() << " -> ";
    s.pop();
  }
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  vector<vector<pair<int, int>>> adj(10);
  adj[0] = vector<pair<int, int>>{{3, 1}, {7, 3}, {8, 4}};
  adj[1] = vector<pair<int, int>>{{3, 0}, {1, 2}, {4, 3}};
  adj[2] = vector<pair<int, int>>{{1, 1}, {2, 3}};
  adj[3] = vector<pair<int, int>>{{7, 0}, {4, 1}, {2, 2}, {3, 4}};
  adj[4] = vector<pair<int, int>>{{8, 0}, {3, 3}};

  auto ans = dijkstra(0, adj);

  // cout << "Distance 0 -> 2: " << ans[2] << endl;
  get_path(ans, 3);

  return 0;
}
