#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

void dfs(vector<vector<int>> mat, int n) {
  vector<bool> visited(mat.size() + 1, false);
  stack<int> s;

  visited[1] = true;
  s.push(1);

  while (!s.empty()) {
    auto curr = s.top();
    s.pop();

    for (int i = 1; i <= mat.size() + 1; i++) {
      if (!visited[i] && mat[curr][i] != 1) {
        if (curr == 2 && i == n + 1) {
          cout << "YES" << endl;
          return;
        }

        s.push(i);
        visited[i] = true;
      }
    }
  }

  cout << "NO" << endl;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int tests;
  int n;
  cin >> tests;

  for (int i = 0; i < tests; i++) {
    cin >> n;

    string num;
    vector<vector<int>> mat(2 + 1, vector<int>(n + 1, 0));
    for (int j = 1; j <= 2; j++) {
      cin >> num;

      for (int k = 1; k <= n; k++) {
        mat[j][k] = num[k - 1] - 48;
      }
    }

    for (int p = 1; p <= 2; ++p) {
      for (int q = 1; q <= n; ++q) {
        cout << mat[p][q] << " ";
      }
      cout << endl;
    }

    dfs(mat, n);
  }

  return 0;
}
