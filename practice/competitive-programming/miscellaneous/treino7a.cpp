#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n;
  cin >> n;

  vector<vector<int>> mat(n + 1, vector<int>(n + 1, 0));
  int in;
  for (int i = 1; i <= n; i++) {
    for (int j = 1; j <= n; j++) {
      cin >> mat[i][j];
    }
  }

  for (int i = 1; i <= n; ++i) {
    for (int j = 1; j <= n; j++) {
      if (mat[i][j] != 0) {
        cout << j << " ";
      }
    }
    cout << endl;
  }

  return 0;
}
