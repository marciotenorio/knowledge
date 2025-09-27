#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

bool bfs(vector<vector<int>> mat) {
  vector<char> colors(mat.size(), 'n');
  queue<int> q;

  colors[0] = 'a';
  q.push(0);

  while (!q.empty()) {
    auto curr = q.front();
    q.pop();

    for (int i = 0; i < mat.size(); i++) {
      if (mat[curr][i] != 0) {
        if (colors[i] == colors[curr] && colors[i] != 'n') {
          return false;
        }
        if (colors[i] == 'n') {
          colors[i] = colors[curr] == 'a' ? 'b' : 'a';
          q.push(i);
        }
      }
    }
  }

  return true;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n = 1, l;
  while (n != 0) {
    cin >> n;
    if (n == 0)
      return 0;
    cin >> l;

    vector<vector<int>> mat(n, vector<int>(n, 0));

    for (int i = 0; i < l; i++) {
      int idx, jdx;
      cin >> idx >> jdx;
      mat[idx][jdx] = 1;
      mat[jdx][idx] = 1;
    }

    //    for (auto i : mat) {
    //      for (auto j : i) {
    //        cout << j << " ";
    //      }
    //      cout << endl;
    //    }

    if (bfs(mat))
      cout << "BICOLORABLE" << endl;
    else
      cout << "NOT BICOLORABLE" << endl;
  }

  return 0;
}
