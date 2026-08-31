#include <bits/stdc++.h>
#include <climits>

using namespace std;
typedef long long ll;

void bfs(vector<vector<int>> mat, int start) {
  vector<bool> visited(mat.size(), false);
  queue<int> q;

  q.push(start);
  visited[start] = true;

  int maxX = INT_MIN;
  int x = 0;
  int minY = INT_MAX;
  while (!q.empty()) {
    auto curr = q.front();
    q.pop();

    bool he = false;
    ;
    for (int i = 1; i < mat.size(); i++) {
      if (mat[curr][i] != 0) {
        ++x;
      }

      if (!visited[i] && mat[curr][i] != 0) {
        q.push(i);
        visited[i] = true;
      }
    }

    maxX = (x > maxX) ? x : maxX;
    x = 0;
  }

  cout << maxX << " " << minY << endl;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int t, n, m, u, v;
  cin >> t;
  for (int i = 0; i < t; i++) {
    cin >> n >> m;

    vector<vector<int>> mat(n + 1, vector<int>(n + 1, 0));
    for (int j = 0; j < m; j++) {
      cin >> u >> v;
      mat[u][v] = 1;
      mat[v][u] = 1;
    }

    bfs(mat, 1);
  }

  return 0;
}
