#include <bits/stdc++.h>
using namespace std;

void bfs(vector<vector<int>> adj) {
  queue<int> q;
  vector<bool> visited(adj.size(), false);
  vector<int> back(adj.size(), -1);

  q.push(1);
  visited[1] = true;

  while (!q.empty()) {
    auto curr = q.front();
    q.pop();

    for (auto i : adj[curr]) {
      if (visited[i]) {
        continue;
      }

      q.push(i);
      visited[i] = true;
      back[i] = curr;
    }
  }

  if (back[adj.size() - 1] == -1) {
    cout << "IMPOSSIBLE" << endl;
    return;
  }

  stack<int> fp;
  int pos = adj.size() - 1;
  while (pos != -1) {
    fp.push(pos);
    pos = back[pos];
  }

  cout << fp.size() << endl;
  while (!fp.empty()) {
    cout << fp.top() << " ";
    fp.pop();
  }

  cout << endl;
}

int main(int argc, char const *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n, m;
  cin >> n >> m;

  vector<vector<int>> adj(n + 1);
  for (int i = 0; i < m; i++) {
    int v, e;
    cin >> v >> e;

    adj[v].push_back(e);
    adj[e].push_back(v);
  }

  bfs(adj);

  return 0;
}
