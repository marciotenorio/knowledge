#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

int dfs(vector<vector<int>> mat, int s1, int s2, int k) {
  vector<bool> visited(mat.size(), false);
  stack<int> stack;
  stack.push(0);
  visited[0] = true;

  while (!stack.empty()) {
    auto node = stack.top();
    stack.pop();

    cout << "Visitando: " << node << endl;

    for (int i = 0; i < mat.size(); i++) {
      if (mat[node][i] == k) {
        cout << node << " " << i << " " << endl;
        return node;
      }
      if (mat[node][i] != 0 && !visited[i]) {
        visited[i] = true;
        stack.push(i);
      }
    }
  }

  return -1;
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

  return dfs(mat, 0, 0, -5);
}
