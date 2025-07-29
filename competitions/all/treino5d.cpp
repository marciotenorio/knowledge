#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

int CC = 0;

int bfs(vector<vector<int>> mat, int v, int s, vector<bool> &visited) {
  int doSearch = 0;
  if (!visited[v])
    doSearch = 1;

  queue<int> q;
  q.push(v);
  visited[v] = true;

  while (!q.empty()) {
    auto curr = q.front();
    q.pop();

    for (int i = 1; i <= s; i++) {
      if (!visited[i] && mat[curr][i] != 0) {
        visited[i] = true;
        q.push(i);
        doSearch = 1;
      }
    }
  }
  return doSearch;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n, m;
  cin >> n >> m;

  if (m == 0 || n == 1) {
    cout << n << endl;
    return 0;
  }

  vector<vector<int>> matrix(n + 1, vector<int>(n + 1, 0));

  int idx, jdx;
  for (int i = 1; i <= m; i++) {
    cin >> idx >> jdx;
    matrix[idx][jdx] = 1;
    matrix[jdx][idx] = 1;
  }

  vector<bool> visited(n + 1, false);
  for (int i = 1; i <= n; i++) {
    auto ans = bfs(matrix, i, n, visited);
    CC += ans;
  }

  cout << CC << endl;

  return 0;
}
