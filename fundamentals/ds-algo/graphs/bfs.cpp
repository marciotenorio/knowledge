#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

void bfs(vector<vector<int>> mat) {
  queue<int> q;
  vector<int> visited(mat.size(), 0);

  q.push(0);
  visited[0] = 1;

  while (!q.empty()) {
    auto node = q.front();
    q.pop();

    cout << "Visitando: " << node << endl;

    for (int i = 0; i < mat.size(); i++) {
      if (visited[i] != 0 && mat[node][i] != 0) {
        visited[i] = visited[node] + 1;
        q.push(i);
      }
    }
  }
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n;
  cin >> n;

  vector<vector<int>> mat(n, vector<int>(n, 0));

  for (int i = 0; i < n; ++i) {
    for (int j = 0; j < n; ++j) {
      cin >> mat[i][j];
    }
  }

  bfs(mat);

  for (int i = 0; i < n; ++i) {
    for (int j = 0; j < n; j++) {
      cout <<
    }
  }

  return 0;
}
